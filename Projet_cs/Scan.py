from msilib import Table
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


### Initialisation des listes de callback
identifier = []
instance = []
offset = []

### Définition du temps comme indicateur de scan 
now = datetime.now()
table_string = str(now.year) + "-" + str(now.month) + "-" + str(now.day) + " " + str(now.hour) + ":" +  str(now.minute) + ":" + str(now.second)


file1 = open("/Users/basti/Desktop/Projet_cs_4/Projet_cs/scan.txt", "w")
file1.truncate(0);
parser = argparse.ArgumentParser()
parser.add_argument("--memory", help="Use Python scipt to scan memory", action="store_true")
parser.add_argument("--fast", help="Use Python script to perform a fast scan")
parser.add_argument("--predefined", help="Use Python script to scan a pre-defined list of files", action="store_true")
parser.add_argument("--imported", help="Use Python script to perform a scan against imported files", type=str)
parser.add_argument("--remove", help="Provide a PID to remove from the list", action="store_true")
parser.add_argument("--add", help="Provide a PID to Add in a list", action="store_true")
parser.add_argument("--pid", help="Provide a PID to Add in a list", type=int)
args = parser.parse_args()


### Result_imported_actions
con_ria = sqlite3.connect("C:\\Users\\basti\\Desktop\\Projet_cs_4\\Projet_cs\\result_imported_actions.db")
cur_ria = con_ria.cursor()
cur_ria.execute("delete from result_scan_actions")
#cur_ria.execute("CREATE TABLE result_scan_actions(date, file)")


### Result_imported_db
con_i = sqlite3.connect("result2.db")
cur_i = con_i.cursor()
cur_i.execute("delete from result_scan_test_manual2")









### Def callback for pid scan
def mycallback_process(data):
  
    return yara.CALLBACK_CONTINUE


### Def Callback for warning message
def warning_callback(warning_type, message):
    return yara.CONTINUE


### Define rule
rules = yara.compile(filepaths={
  'namespace1':'/Users/basti/Desktop/Projet/Fichiers de Score/Score.yar', 
  'namespace2':'/Users/basti/Desktop/Projet/Spyware/Spyware.yar'
})


# Imported File, conversion
if args.imported:
    def mycallback_files(data):
        data = str(data)
        data2 = data.replace("'", "").replace(",", "\n").replace("{", "").replace("}", "").replace("matches: True", "############################# \nDetected threat against rule:\n")
        ##file1.write(data2 + "\n"  + "\n")
        return yara.CALLBACK_CONTINUE

    ### Correction de la syntaxe
    string = args.imported
    new_string = string.replace("C:\\", "/")
    argument = new_string.replace("\\", "/")
    file1.write("Selected file :" + argument + "\n")

    ### Matches
    matches = rules.match(argument, callback=mycallback_files, which_callbacks=yara.CALLBACK_MATCHES, warnings_callback=warning_callback)
    i = len(matches)
    
    ### Write into actions DB
    if (i > 0):
        data = [
            (str(table_string), str(string))
            ] 
        cur_ria.executemany("INSERT INTO result_scan_actions VALUES(?, ?)", data)
        con_ria.commit()
        #res = cur_ria.execute("select * from result_scan_actions")
        #print(res.fetchall())


    ### Write into file to show
    for x in range(i):
        file1.write("############################################\n\n")
        file1.write("The engine detected a threat againt rule : " + str(matches[x].rule) + "\n")
        meta_i = str(matches[x].meta) 
        meta_f = meta_i.replace("'", "").replace("{", "").replace("}", "")
        file1.write(str(meta_f) + "\n" + "\n")
        for y in range(len(matches[x].strings)):
            file1.write("The threat was an " + str(matches[x].strings[y].identifier) + "\n")
            file1.write("The dangerous strings was : " + str(matches[x].strings[y].instances) + "\n") 
            file1.write("Located at offset : " + str(matches[x].strings[y].instances[0].offset) + "\n" + "\n")
            

    ### Ecriture de fin de programme
    file1.write("\n" + "\n" + "Number of detected thread : " + str(i) + "\n")
    delta = time.time() - start_time
    file1.write("This program has been executed in " + str(delta) + " seconds" + "\n")
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
    file1.close



### Scan de mémoire

if args.memory:
    if args.add:
        pid = args.pid
        if pid in psutil.pids():
            try:
                file1.write("Scanning against pid : " + str(pid) + "\n")
                p = psutil.Process(pid)
                file1.write("With name : " + str(p.name()) + "\n")
                file1.write("With parent process : " + str(p.parent()) + "\n")
                file1.write("Lauched by the user : " + str(p.username()) + "\n")
                matches = rules.match(pid=pid, callback=mycallback_process, which_callbacks=yara.CALLBACK_MATCHES, warnings_callback=warning_callback)
                i = len(matches)
                for x in range(i):
                    file1.write("############################################\n\n")
                    file1.write("The engine detected a threat againt rule : " + str(matches[x].rule) + "\n")
                    meta_i = str(matches[x].meta)
                    meta_f = meta_i.replace("'", "").replace("{", "").replace("}", "")
                    file1.write(str(meta_f) + "\n" + "\n")
                    for y in range(len(matches[x].strings)):
                        file1.write("The threat was an " + str(matches[x].strings[y].identifier) + "\n")
                        file1.write("The dangerous strings was : " + str(matches[x].strings[y].instances) + "\n") 
                        file1.write("Located at offset : " + str(matches[x].strings[y].instances[0].offset) + "\n" + "\n")
                
            except yara.Error:
                file1.write("An error was detected while scanning the Process\n\n")
            except yara.TimeoutError:
                file1.write("The engine has reached the timeout\n" + "Check if your process isn't in trouble\n")
            delta = time.time() - start_time
            file1.write("This program has been executed in " + str(delta) + " seconds" + "\n")
        else:
            file1.write("The provided PID doesn't exist : " + str(pid) + "\n")
            delta = time.time() - start_time
            file1.write("This program has been executed in " + str(delta) + " seconds" + "\n")
            
    elif args.remove:
        list_pid = psutil.pids()
        list_pid.remove(args.pid)
        for pids in list_pid:
            try:
                file1.write("Scanning against pid : " + str(pids) + "\n")
                matches = rules.match(pid=pids, callback=mycallback_process, which_callbacks=yara.CALLBACK_MATCHES, warnings_callback=warning_callback)
            except yara.Error:
                file1.write("An error was detected while scanning the Process\n\n")
            except yara.TimeoutError:
                file1.write("The engine has reached the timeout\n" + "Check if your process isn't in trouble ")
            delta = time.time() - start_time
            file1.write("This program has been executed in " + str(delta) + " seconds" + "\n")    
    elif (str(args.add) == "False") and (str(args.remove) == "False"):
        list_pid = psutil.pids()
        for pids in list_pid:
            try:
                file1.write("Scanning against pid : " + str(pids) + "\n")
                matches = rules.match(pid=pids, callback=mycallback_process, which_callbacks=yara.CALLBACK_MATCHES, warnings_callback=warning_callback)
            except yara.Error:
                file1.write("An error was detected while scanning the Process\n\n")
            except yara.TimeoutError:
                file1.write("The engine has reached the timeout\n" + "Check if your process isn't in trouble \n")
            delta = time.time() - start_time
            file1.write("This program has been executed in " + str(delta) + " seconds" + "\n")



### Pre-defined scan

if args.predefined:
    totfiles = ["C:/Users/basti/Documents/", "C:/Users/basti/Desktop/", "C:/Users/basti/Downloads", "C:/Users/basti/Pictures"]
    for files in totfiles:
        files = [f for f in pathlib.Path(files).iterdir() if f.is_file()] 
        for x in files:
            x = str(x)
            file1.write("Scanning againt file : " + x + "\n")
            def mycallback(data):
                #data = str(data)
                #data2 = data.replace("'", "").replace(",", "\n").replace("{", "").replace("}", "").replace("matches: True", "Detected threat against :\n")
                #string_to_write = data2 + "\n" + "#############################" + "\n"
                return yara.CALLBACK_CONTINUE
            try:
                matches = rules.match(x, callback=mycallback, which_callbacks=yara.CALLBACK_MATCHES, timeout=30)
    
                i = len(matches)
                print(i)
                if (i > 0):
                    a = "\n" + "Number of detected thread : " + str(i) + "\n" + "\n"
                    print("detected")
                    n = 0
                    #res = cur_i.execute("select * from result_scan_test_manual2")
                    ### Loop for matches
                    for x in range(i):
                    
                        n = n + 1
                        file1.write("############################################\n\n")
                        file1.write("This rule was the rule number : " + str(n) + "\n")
                        file1.write("The engine detected a threat againt rule : " + str(matches[x].rule) + "\n")
                        meta_i = str(matches[x].meta) 
                        meta_f = meta_i.replace("'", "").replace("{", "").replace("}", "")
                        file1.write(str(meta_f) + "\n" + "\n")
                        for y in range(len(matches[x].strings)):
                            file1.write("The threat was an " + str(matches[x].strings[y].identifier) + "\n")
                            file1.write("The dangerous strings was : " + str(matches[x].strings[y].instances) + "\n") 
                            file1.write("Located at offset : " + str(matches[x].strings[y].instances[0].offset) + "\n" + "\n")
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
                    file1.write("No threats were detected in this file\n\n")
            except yara.TimeoutError:
                file1.write("The scanning process has reach the timeout\n\n")
            except yara.Error:
                file1.write("A error has been detcted\n\n")
    delta = time.time() - start_time
    file1.write("This program has been executed in " + str(delta) + " seconds" + "\n")
    file1.close()
    


    



