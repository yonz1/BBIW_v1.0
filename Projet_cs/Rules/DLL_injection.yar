import "pe"
import "math"
import "hash"

rule DLL_injection {
    meta:
        Actions = "Fonctions pouvant être utiliser pour injecter du code dans la mémoire" 
    strings:
        $API1 = "OpenProcess(PROCESS_ALL_ACCESS"
        $API2 = "VirtualAllocEx"
        $API3 = "WriteProcessMemory"
        $API5 = "CreateRemoteThread"
        $API6 = "GetProcAddress"
        $API7 = "VirtualProtectEx"
    condition:
        all of them and filesize < 100KB and pe.DLL
}
 
rule Reflect_dll_injection{
    meta:
        Actions = "Fonctions pouvant être utiliser pour injecter du code dans la mémoire"

    strings:
		$IMPORT = "pch.h"  
		$API1 = "GetModuleHandleA"
		$API2 = "CreateFileA"
		$API3 = "GetFileSize"
		$API4 = "HeapAlloc(GetProcessHeap()"
		$API5 = "ReadFile"
		$API6 = "memcpy"
		$API7 = "VirtualAlloc"
		$API8 = "ReadProcessMemory(GetCurrentProcess()"
		$API9 = "HeapFree(GetProcessHeap()"
    condition:
        6 of them
}

rule meterpreter_inject {
	meta:
		Actions = "Fonctions pouvant être utiliser pour injecter du code dans la mémoire"

	strings:
		$Import = "resource.h"
		$Import1 = "pch.h"
		$Function = "FindResource"
		$Function1 = "SizeofResource"
		$Function2 = "LoadResource"
		$API = "VirtualAlloc"
		$API1 = "memcpy(exec"
		$Function4 = "((void(*)())exec)();"
	condition:
		6 of them and filesize < 50KB
}

rule shellcode_metasploit {
	meta:
		Actions = "Fonctions pouvant être utiliser pour injecter du code dans la mémoire"
	strings:
		$hex_value = {31 c9 64 8b 71 30 8b 76 0c 8b 76 1c 8b 46 08 8b 7e 20 8b 36 38 4f 18 75 f3 59 01 d1 ff e1 60 8b 6c 24 24 8b 45 3c 8b 54 28 78 01 ea 8b 4a 18 8b 5a 20 01 eb e3 34 49 8b 34 8b 01 ee 31 ff 31 c0 fc ac 84 c0 74 07 c1 cf 0d 01 c7 eb f4 3b 7c 24 28 75 e1 8b 5a 24 01 eb 66 8b 0c 4b 8b 5a 1c 01 eb 8b 04 8b 01 e8 89 44 24 1c 61 c3}
	condition:
		$hex_value
}





