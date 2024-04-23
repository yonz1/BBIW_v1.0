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
start_time = time.time()

#conn = pymysql.connect(
#    db='Result.db'
#    )



file1 = open("/Users/basti/Desktop/Projet_cs_4/Projet_cs/scan.txt", "w")
file1.truncate(0);
parser = argparse.ArgumentParser()
parser.add_argument("--memory", help="Use Python scipt to scan memory", action="store_true")
parser.add_argument("--fast", help="Use Python script to perform a fast scan")
parser.add_argument("--predefined", help="Use Python script to scan a pre-defined list of files")
parser.add_argument("--imported", help="Use Python script to perform a scan against imported files", type=str)
parser.add_argument("--remove", help="Provide a PID to remove from the list", action="store_true")
parser.add_argument("--add", help="Provide a PID to Add in a list", action="store_true")
parser.add_argument("--pid", help="Provide a PID to Add in a list", type=int)
args = parser.parse_args()





### Def callback for pid scan
def mycallback_process(data):
    data = str(data)
    data2 = data.replace("'", "").replace(",", "\n").replace("{", "").replace("}", "").replace("matches: True", "############################# \nDetected threat against rule:\n")
    file1.write(data2 + "\n"  + "\n")
    return yara.CALLBACK_CONTINUE


### Def Callback for warning message
def warning_callback(warning_type, message):
    return yara.CONTINUE
    #if warning_type == yara.CALLBACK_TOO_MANY_MATCHES:
    #    print(f"namespace:'{message.namespace}' rule:'{message.rule}' string:'{message.string}'")
    #    return yara.CALLBACK_CONTINUE
    #if warning_type == yara.ERROR:
    #    print("The error was:" + message)
    #    return yara.CALLBACK_CONTINUE
        

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

    string = args.imported
    new_string = string.replace("C:\\", "/")
    argument = new_string.replace("\\", "/")
    file1.write("Selected file :" + argument + "\n")

    ### Matches
    matches = rules.match(argument, callback=mycallback_files, which_callbacks=yara.CALLBACK_MATCHES, warnings_callback=warning_callback)
    i = len(matches)
    for x in range(i):
        file1.write("############################################\n\n")
        file1.write("The engine detected a threat againt rule : " + str(matches[x].rule) + "\n")
        file1.write(str(matches[x].meta) + "\n" + "\n")
        for y in range(len(matches[x].strings)):
            file1.write("The threat was an " + str(matches[x].strings[y].identifier) + "\n")
            file1.write("The dangerous strings was : " + str(matches[x].strings[y].instances) + "\n") 
            file1.write("Located at offset : " + str(matches[x].strings[y].instances[0].offset) + "\n" + "\n")
        
    file1.write("\n" + "\n" + "Number of detected thread : " + str(i) + "\n")
    delta = time.time() - start_time
    file1.write("This program has been executed in " + str(delta) + " seconds" + "\n")
    file1.close
    


if args.memory:
    if args.add:
        pid = args.pid
        if pid in psutil.pids():
            try:
                file1.write("Scanning against pid : " + str(pid) + "\n")
                matches = rules.match(pid=pid, callback=mycallback_process, which_callbacks=yara.CALLBACK_MATCHES, warnings_callback=warning_callback)
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

#if args.memory and args.add and (args.remove == "False"):
#    print("Add Scan selected")
#    pid = args.pid
#    try:
#        print("Scanning against pid : " + str(pid))
#        matches = rules.match(pid=pid, callback=mycallback_process, which_callbacks=yara.CALLBACK_MATCHES, warnings_callback=warning_callback)
#    except yara.Error:
#        print("An error was detected while scanning the Process\n")
#    except yara.TimeoutError:
#        print("The engine has reached the timeout\n" + "Check if your process isn't in trouble ")
#    
#
#if args.memory and (args.add != "true") and args.remove:
#    print("Remove Scan selected")
#    list_pid = psutil.pids()
#    list_pid.remove(args.pid)
#    print(args)
#    for pids in list_pid:
#        try:
#            print("Scanning against pid : " + str(pids))
#            matches = rules.match(pid=pids, callback=mycallback_process, which_callbacks=yara.CALLBACK_MATCHES, warnings_callback=warning_callback)
#        except yara.Error:
#            print("An error was detected while scanning the Process\n")
#        except yara.TimeoutError:
#            print("The engine has reached the timeout\n" + "Check if your process isn't in trouble ")
#    
#
#### Memory scan
#if args.memory and (args.add != "true") and (args.remove != "true"):
#    print("All memory Scan selected")
#    list_pid = psutil.pids()
#    for pids in list_pid:
#        try:
#            print("Scanning against pid : " + str(pids))
#            matches = rules.match(pid=pids, callback=mycallback_process, which_callbacks=yara.CALLBACK_MATCHES, warnings_callback=warning_callback)
#        except yara.Error:
#            print("An error was detected while scanning the Process\n")
#        except yara.TimeoutError:
#            print("The engine has reached the timeout\n" + "Check if your process isn't in trouble ")
#
#
    

    ### Filter programm 
    ### To in order to konw the difference of execution time
    
        
    #argument = args.memory
    #file1.write("Scanning process" + str(argument))
    #matches =  rules.match(pid=argument, callback=mycallback_process, which_callbacks=yara.CALLBACK_MATCHES, warnings_callback=warning_callback)
    #print(matches)
    #list_pid = psutil.pids()
    #list_pid.remove(0)
    #list_pid.remove(4)
    #current_pid = os.getpid()
    #print(current_pid)
    #p2 = psutil.Process(current_pid)
    #user_name = p2.username()
    #print(user_name)
    #for proc in psutil.process_iter(['username','pid']):
    #    try:
    #        cmdline = proc.cmdline()
    #    except psutil.AccessDenied:
    #        list_pid.remove(proc.pid)
    #        print("Removed : " + str(proc.pid))
    #        continue
    #    except (psutil.ZombieProcess, psutil.NoSuchProcess):
    #        list_pid.remove(proc.pid)
    #        print("Zombie")
    #        continue
    #    except Exception as e:
    #        print("Quelque chose ne vas pas avec ce processus")
    #        
    #    x = proc.info['pid']
    #    p = psutil.Process(x)
    #    string = str(p.parent())
    #    Av_solution = string.find('QHActiveDefense')
    #    print(Av_solution)
    #    if ((proc.info['username'] == user_name) and (Av_solution == -1)):
    #        print("Good user find at pid : " + str(proc.info['pid']))
    #    else:
    #        print("Bad user find at pid : " + str(proc.info['pid']))
    #        if x in list_pid:
    #             list_pid.remove(x)
    #             print("Removed while in list: " + str(proc.info['pid']))
    #print(list_pid)
   

    ### Second filtrer programm

   # user_name = getpass.getuser()
   # print(user_name)
   # process_dict = {proc.pid:proc.name() for proc2 in psutil.process_iter() if proc.username() == user_name}
   # print(process_dict)
   # print(os.getlogin())
    #user_name = getpass.getuser()
    #print(user_name)

        #    list_pid.remove(proc2.info['pid'])
        #    print("Removed : " + str(proc2.info['pid']))



        #for pids in list_pid:
        #print("Scanning against : " + str(pids))
        #file1.write("Scanning against : " + str(pids))
        #p = psutil.Process.parent(pids)
        #string = str(p.parent())
        #print(string)
        #if string.find('QHActiveDefense') != -1:
        #    print("find AV process")
        #else:
        #    print("Process thaht will be scanned : " + str(pids))
        #    #matches = rules.match(pid=pids, callback=mycallback_process, which_callbacks=yara.CALLBACK_MATCHES, warnings_callback=warning_callback)
        #    #print(matches)
           
    
    





### Fast scan

 




### Pre-defined scan

    



