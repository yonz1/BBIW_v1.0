import io
from msilib import Table
from msilib.schema import File
from operator import length_hint
import pstats
import sys
import sysconfig
import os
import yara
import argparse
import psutil
import getpass
import sqlite3
from datetime import datetime, timedelta
import time
import pathlib
start_time = time.time()
current_dir = os.getcwd()
current_dir = current_dir.replace("C:\\", "/")
current_dir = current_dir.replace("\\", "/")
print(current_dir)

### Initialisation des listes de callback
identifier = []
instance = []
offset = []
valtot = []

### Définition du temps comme indicateur de scan 
now = datetime.now()
table_string = str(now.year) + "-" + str(now.month) + "-" + str(now.day) 


file_i = open("../../scan_i.txt", "w")
file_p = open("../../scan_p.txt", "w")
file_pr = open("../../scan_pr.txt", "w")
Save_rule = open("./Save_rule.txt", "w")
file_i.truncate(0);
file_p.truncate(0);
file_pr.truncate(0);
parser = argparse.ArgumentParser()
parser.add_argument("--memory", help="Use Python scipt to scan memory", action="store_true")
parser.add_argument("--fast", help="Use Python script to perform a fast scan", action="store_true")
parser.add_argument("--predefined", help="Use Python script to scan a pre-defined list of files", action="store_true")
parser.add_argument("--imported", help="Use Python script to perform a scan against imported files", type=str)
parser.add_argument("--remove", help="Provide a PID to remove from the list", action="store_true")
parser.add_argument("--add", help="Provide a PID to Add in a list", action="store_true")
parser.add_argument("--pid", help="Provide a PID to Add in a list", type=int)
args = parser.parse_args()


### Result_imported_actions


### Result_imported_db
con_i = sqlite3.connect("../../result2.db")
cur_i = con_i.cursor()
#cur_i.execute("delete from result_scan_test_manual2")



###  result_scan_test_manual2 pour le stockage des détection 
### result_scan_actions pour les actions de fichier imported

### ... pour le stockage des détection contre processus 
### result_scan_actions_process pour les actions de processus

### ... pour le stockage des détection contre les prédéfinies
### ... pour le stockage des actions contres les prédéfinies

### result_scan_all pour le dashboard




### Def callback for pid scan
def mycallback_process(data):
  
    return yara.CALLBACK_CONTINUE


### Def Callback for warning message
def warning_callback(warning_type, message):
    return yara.CONTINUE


#### 
#files = [f for f in pathlib.Path("../../Rules/").iterdir() if f.is_file()] 
##buff = Buffer(0)
#i = 1;
#### Define rule
for rule in files:
    try:  
        #rule = str(rule)
        #rule = rule.replace("\\", "/")
        #value = "namespace" +  str(i) + "\'" + ':' + "\'" + rule 
        #print(value)
        #i = i + 1
        #valtot.append(value)
        #rules = yara.compile=(filepaths={value})
        #print(rule)
        #print(i)
        #rules = yara.compile(filepath=rule)
        #path = "../../Compiled_rule/" + "rules_" + str(i)
        #f = open(path, 'w')
        ##path = "../../Compiled_rules/rules"
        #rules.save(path)
        #i= i + 1
        #buff = buff + Buffer(rules)
        rules = yara.compile(filepaths={
         'namespace1':'../../Rules/Score.yar', 
         'namespace2':'../../Rules/Spyware.yar',
         'namespace3':'../../Rules/Cryptage_cle.yar',
         'namespace4':'../../Rules/CryptoRansom.yar',
         'namespace5':'../../Rules/DLL_injection.yar',
         'namespace6':'../../Rules/HashRAT.yar',
         'namespace7':'../../Rules/Mitre_Att&ck_technique.yar',
         'namespace8':'../../Rules/Process_injection.yar',
         'namespace9':'../../Rules/RansomHash.yar',
         'namespace10':'../../Rules/Revshell.yar',
         'namespace11':'../../Rules/shellcode.yar',
         'namespace12':'../../Rules/trojan.yar'
       })
    except yara.Error as e:
        print("Une erreur s'est produite : ", e)
        if args.imported:
            file_i.write("Error occured while compiling a rules\n")
        if args.memory:
            file_p.write("Error occured while compiling a rules\n")
        if args.predefined:
            file_pr.write("Error occured while compiling a rules\n")
    

#print(valtot)
#rules = yara.compile(filepaths={valtot})
#for x in range(i):
#    try:
#        print(x)
#        path = "../../Compiled_rule/" + "rules_" + str(x)
#        rules = yara.load(path)
#        x = x + 1
#        print("load : ", path)
#    except yara.Error as e:
#        print("Error while loading rules", e)
#
# Imported File, conversion
if args.imported:
    def mycallback_files(data):
        data = str(data)
        data2 = data.replace("'", "").replace(",", "\n").replace("{", "").replace("}", "").replace("matches: True", "############################# \nDetected threat against rule:\n")
        return yara.CALLBACK_CONTINUE

    ### Correction de la syntaxe
    string = args.imported
    new_string = string.replace("C:\\", "/")
    argument = new_string.replace("\\", "/")
    file_i.write("Selected file : " + argument + "\n")

    data = [ str(string)]
    exist = cur_i.execute("SELECT COUNT(*) from result_scan_actions where file like ?", data)
    count = str(exist.fetchall()).replace("(", "").replace(")", "").replace("[", "").replace("]", "").replace(",", "")
    if (int(count) == 0):
        cur_i.execute("INSERT INTO result_scan_all VALUES(?)", data)
        con_i.commit()

    ### Matches 
    matches = rules.match(argument, callback=mycallback_files, which_callbacks=yara.CALLBACK_MATCHES, warnings_callback=warning_callback)
    i = len(matches)
    ### Insertion dans la base de données
    if (i > 0):
        data = [
            (str(string))
            ] 
        exist = cur_i.execute("SELECT COUNT(*) from result_scan_actions where file like ?", data)
        count = str(exist.fetchall()).replace("(", "").replace(")", "").replace("[", "").replace("]", "").replace(",", "")
        if (int(count) == 0):
            print("insert")
            cur_i.execute("INSERT INTO result_scan_actions VALUES(?)", data)
            con_i.commit()

       


    ### Ecriture dans le fichier 
    for x in range(i):
        file_i.write("############################################\n\n")
        file_i.write("The engine detected a threat againt rule : " + str(matches[x].rule) + "\n")
        meta_i = str(matches[x].meta) 
        meta_f = meta_i.replace("'", "").replace("{", "").replace("}", "")
        file_i.write(str(meta_f) + "\n" + "\n")
        for y in range(len(matches[x].strings)):
            file_i.write("The threat was an " + str(matches[x].strings[y].identifier) + "\n")
            file_i.write("The dangerous strings was : " + str(matches[x].strings[y].instances) + "\n") 
            file_i.write("Located at offset : " + str(matches[x].strings[y].instances[0].offset) + "\n" + "\n")
            

    ### Ecriture de fin de programme
    file_i.write("\n" + "\n" + "Number of detected threat : " + str(i) + "\n")
    delta = time.time() - start_time
    file_i.write("This program has been executed in " + str(delta) + " seconds" + "\n")
    n = 0


    ### Syntaxe de stockage dans la base de données de résultat
    for x in range(i):
        n = n + 1
        numero = str(n)
        name = str(matches[x].rule)
        meta = str(matches[x].meta)
        id = name + " : " + meta
        for y in range(len(matches[x].strings)):
            identifier.append(str(matches[x].strings[y].identifier)) 
            instance.append(str(matches[x].strings[y].instances))
            offset.append(str(matches[x].strings[y].instances[0].offset))
        
        data = [
            (str(table_string), str(numero), str(id), str(identifier), str(instance), str(offset))
            ]
        cur_i.executemany("INSERT INTO result_scan_test_manual2 VALUES(?, ?, ?, ?, ?, ?)", data)
        con_i.commit()
        identifier.clear()
        instance.clear()
        offset.clear()
        
    identifier.clear()
    instance.clear()
    offset.clear()
    file_i.close
    file_p.close()



### Scan de mémoire

if args.memory:
    if args.add:
        pid = args.pid
        if pid in psutil.pids():
            try:
                file_p.write("Scanning against pid : " + str(pid) + "\n")
                p = psutil.Process(pid)
                file_p.write("With name : " + str(p.name()) + "\n")
                file_p.write("With parent process : " + str(p.parent()) + "\n")
                file_p.write("Lauched by the user : " + str(p.username()) + "\n")
                
                data = [ str(pid)]
                cur_i.execute("INSERT INTO result_scan_all VALUES(?)", data)
                con_i.commit()
                matches = rules.match(pid=pid, callback=mycallback_process, which_callbacks=yara.CALLBACK_MATCHES, warnings_callback=warning_callback)
                i = len(matches)
                
                ### Stockage dans la base de données 
                if (i > 0):
                     data = [
                         (str(pid))
                         ] 
                     exist = cur_i.execute("SELECT COUNT(*) from result_scan_actions_process where pids like ?", data)
                     count = str(exist.fetchall()).replace("(", "").replace(")", "").replace("[", "").replace("]", "").replace(",", "")
                     if (int(count) == 0):
                         cur_i.execute("INSERT INTO result_scan_actions_process VALUES(?)", data)
                         con_i.commit()
                         res = cur_i.execute("select * from result_scan_actions_process")
                         print(res.fetchall())
                    


                ### Bouclage pour l'écriturea dans le fichier 
                for x in range(i):
                    file_p.write("############################################\n\n")
                    file_p.write("The engine detected a threat againt rule : " + str(matches[x].rule) + "\n")
                    meta_i = str(matches[x].meta)
                    meta_f = meta_i.replace("'", "").replace("{", "").replace("}", "")
                    file_p.write(str(meta_f) + "\n" + "\n")
                    for y in range(len(matches[x].strings)):
                        file_p.write("The threat was an " + str(matches[x].strings[y].identifier) + "\n")
                        file_p.write("The dangerous strings was : " + str(matches[x].strings[y].instances) + "\n") 
                        file_p.write("Located at offset : " + str(matches[x].strings[y].instances[0].offset) + "\n" + "\n")
                

            ### Gestion d'erreur 
            except yara.Error:
                file_p.write("An error was detected while scanning the Process\n\n")
            except yara.TimeoutError:
                file_p.write("The engine has reached the timeout\n" + "Check if your process isn't in trouble\n")
            delta = time.time() - start_time
            file_p.write("This program has been executed in " + str(delta) + " seconds" + "\n")
        else:
            file_p.write("The provided PID doesn't exist : " + str(pid) + "\n")
            delta = time.time() - start_time
            file_p.write("This program has been executed in " + str(delta) + " seconds" + "\n")
            
    elif args.remove:
        list_pid = psutil.pids()
        list_pid.remove(args.pid)
        for pids in list_pid:
            try:
                file_p.write("Scanning against pid : " + str(pids) + "\n")
                data = [ str(pids)]
                cur_i.execute("INSERT INTO result_scan_all VALUES(?)", data)
                con_i.commit()
                matches = rules.match(pid=pids, callback=mycallback_process, which_callbacks=yara.CALLBACK_MATCHES, warnings_callback=warning_callback)
            except yara.Error:
                file_p.write("An error was detected while scanning the Process\n\n")
            except yara.TimeoutError:
                file_p.write("The engine has reached the timeout\n" + "Check if your process isn't in trouble ")
            delta = time.time() - start_time
            file_p.write("This program has been executed in " + str(delta) + " seconds" + "\n")    
    elif (str(args.add) == "False") and (str(args.remove) == "False"):
        list_pid = psutil.pids()
        for pids in list_pid:
            try:
                file_p.write("Scanning against pid : " + str(pids) + "\n")
                data = [ str(pids)]
                cur_i.execute("INSERT INTO result_scan_all VALUES(?)", data)
                con_i.commit()
                matches = rules.match(pid=pids, callback=mycallback_process, which_callbacks=yara.CALLBACK_MATCHES, warnings_callback=warning_callback)
            except yara.Error:
                file_p.write("An error was detected while scanning the Process\n\n")
            except yara.TimeoutError:
                file_p.write("The engine has reached the timeout\n" + "Check if your process isn't in trouble \n")
            delta = time.time() - start_time
            file_p.write("This program has been executed in " + str(delta) + " seconds" + "\n")



### Pre-defined scan

if args.predefined:
    totfiles = ["C:/Users/basti/Documents/", "C:/Users/basti/Desktop/", "C:/Users/basti/Downloads", "C:/Users/basti/Pictures"]
    for files in totfiles:
        files = [f for f in pathlib.Path(files).iterdir() if f.is_file()]
        for x in files:
            x = str(x)
            file_pr.write("Scanning againt file : " + x + "\n")
            def mycallback(data):
                #data = str(data)
                #data2 = data.replace("'", "").replace(",", "\n").replace("{", "").replace("}", "").replace("matches: True", "Detected threat against :\n")
                #string_to_write = data2 + "\n" + "#############################" + "\n"
                return yara.CALLBACK_CONTINUE 
            try:
                data = [ str(x)]
                cur_i.execute("INSERT INTO result_scan_all VALUES(?)", data)
                con_i.commit()
                matches = rules.match(x, callback=mycallback, which_callbacks=yara.CALLBACK_MATCHES, timeout=30, fast=args.fast)
    
                i = len(matches)
                print(i)
                if (i > 0):
                    a = "\n" + "Number of detected threat : " + str(i) + "\n" + "\n"
                    print("detected")
                    n = 0
                    #res = cur_i.execute("select * from result_scan_test_manual2")
                    ### Loop for matches
                    for x in range(i):
                    
                        n = n + 1
                        file_pr.write("############################################\n\n")
                        file_pr.write("This rule was the rule number : " + str(n) + "\n")
                        file_pr.write("The engine detected a threat againt rule : " + str(matches[x].rule) + "\n")
                        meta_i = str(matches[x].meta) 
                        meta_f = meta_i.replace("'", "").replace("{", "").replace("}", "")
                        file_pr.write(str(meta_f) + "\n" + "\n")
                        for y in range(len(matches[x].strings)):
                            file_pr.write("The threat was an " + str(matches[x].strings[y].identifier) + "\n")
                            file_pr.write("The dangerous strings was : " + str(matches[x].strings[y].instances) + "\n") 
                            file_pr.write("Located at offset : " + str(matches[x].strings[y].instances[0].offset) + "\n" + "\n")
                    ### Syntaxe de stockage dans la base de données de résultat
                    n = 0
                    for x in range(i):
                        n = n + 1
                        numero = str(n)
                        name = str(matches[x].rule)
                        meta = str(matches[x].meta)
                        id = name + " : " + meta
                        for y in range(len(matches[x].strings)):
                            identifier.append(str(matches[x].strings[y].identifier)) 
                            instance.append(str(matches[x].strings[y].instances))
                            offset.append(str(matches[x].strings[y].instances[0].offset))
                        
                        data = [
                            (str(table_string), str(numero), str(id), str(identifier), str(instance), str(offset))
                            ]
                        cur_i.executemany("INSERT INTO result_scan_test_manual2 VALUES(?, ?, ?, ?, ?, ?)", data)
                        con_i.commit()
                        identifier.clear()
                        instance.clear()
                        offset.clear()
                        
                    identifier.clear()
                    instance.clear()
                    offset.clear()
                else:
                    file_pr.write("No threats were detected in this file\n\n")
            except yara.TimeoutError:
                file_pr.write("The scanning process has reach the timeout\n\n")
            except yara.Error:
                file_pr.write("A error has been detcted\n\n")
    delta = time.time() - start_time
    file_pr.write("This program has been executed in " + str(delta) + " seconds" + "\n")
    file_pr.close()
    file_i.close()
    


    
