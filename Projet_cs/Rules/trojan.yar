import "pe"
import "hash"
import "math"
import "elf"

rule CVE_2023_21768 {
	meta:
		Action = "Exploite le pilote AFD (Ancillary Function Drive) afin d'élver les priviléges d'un utilisateur "
	strings:
		$GetNtFunctions = "_NtCreateFile = (unsigned long(__stdcall*)(PHANDLE, unsigned long, POBJECT_ATTRIBUTES, PIO_STATUS_BLOCK, PLARGE_INTEGER, unsigned long, unsigned long, unsigned long, unsigned long, void*, unsigned long))GetProcAddress(GetModuleHandleA('ntdll.dll'), 'NtCreateFile');" nocase
		$GetNtFunctions1 = "_NtDeviceIoControlFile = (unsigned long(__stdcall*)(HANDLE, void*, void*, void*, PIO_STATUS_BLOCK, unsigned long, void*, unsigned long, void*, unsigned long))GetProcAddress(GetModuleHandleA('ntdll.dll'), 'NtDeviceIoControlFile');"  nocase
		$GetNtFunctions2 = "_NtCreateIoCompletion = (unsigned long(__stdcall*)(PHANDLE, unsigned long, POBJECT_ATTRIBUTES, unsigned long))GetProcAddress(GetModuleHandleA('ntdll.dll'), 'NtCreateIoCompletion');" wide nocase
		$GetNtFunctions3 = "_NtSetIoCompletion = (unsigned long(__stdcall*)(HANDLE, unsigned long, PIO_STATUS_BLOCK, NTSTATUS, unsigned long))GetProcAddress(GetModuleHandleA('ntdll.dll'), 'NtSetIoCompletion');" wide nocase
		$GetNtFunctions4 = "_NtQuerySystemInformation = (unsigned long(__stdcall*)(SYSTEM_INFORMATION_CLASS, PVOID, ULONG, PULONG))GetProcAddress(GetModuleHandleA('ntdll.dll'), 'NtQuerySystemInformation');" nocase
		$Socket = "0x00, 0x00, 0x00, 0x00, 0x00, 0x0F, 0x1E, 0x00, 0x41, 0x66, 0x64, 0x4F, 0x70, 0x65, 0x6E, 0x50,0x61, 0x63, 0x6B, 0x65, 0x74, 0x58, 0x58, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,0x02, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x06, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,0x00, 0x00, 0x00, 0x00, 0x60, 0xEF, 0x3D, 0x47, 0xFE" wide
		$File = "ret = _NtCreateFile(&hSocket, MAXIMUM_ALLOWED, &ObjectAttributes, &IoStatusBlock, NULL, 0, FILE_SHARE_READ | FILE_SHARE_WRITE, 1, 0, bExtendedAttributes, sizeof(bExtendedAttributes));"
		$Data1 = "Data.hCompletion = hCompletion;" wide nocase
    	$Data2 = "Data.pData1 = VirtualAlloc(NULL, 0x2000, MEM_RESERVE | MEM_COMMIT, PAGE_READWRITE);" wide nocase
    	$Data3 = "Data.pData2 = VirtualAlloc(NULL, 0x2000, MEM_RESERVE | MEM_COMMIT, PAGE_READWRITE);" wide nocase
    	$Data4 = "Data.dwCounter = 0x1;" wide nocase
    	$Data5 = "Data.dwLen = 0x1;" wide nocase
    	$Data6 = "Data.dwTimeout = 100000000;" wide nocase
    	$Data = "Data.pPwnPtr = pPwnPtr;" wide nocase
		$Control = "_NtDeviceIoControlFile(hSocket, hEvent, NULL, NULL, &IoStatusBlock, AFD_NOTIFYSOCK_IOCTL, &Data, 0x30, NULL, 0);" wide 
	condition:
		all of them 
}

rule CVE_2018_0802{
	meta:
		Action = "Permet une exécution de code à distance due à probléme de gestion de mémoire dans l'éditeur d'équation Microsoft Office"
	strings:
		$Object_header1 = "szClassName = struct.pack('<I', len(ClassName) + 1).encode('hex')"
		$Object_header = "szPackageData = struct.pack('<I', len(self.get_package_data())/2).encode('hex')" 
		$Main_action1 = "StreamHeader = '0200'" wide nocase
        $Main_action2 = "Label = self.filename.encode('hex') + '00'" wide nocase
        $Main_action3 = "OrgPath = self.orgpath.encode('hex') + '00'" wide nocase
        $Main_action4 = "UType = '00000300'" wide nocase
        $Main_action5 = "DataPath = self.datapath.encode('hex') + '00'" wide nocase
        $Main_action6 = "DataPathLen = struct.pack('<I', len(self.datapath)+1).encode('hex')" wide nocase
        $Main_action14 = "DataLen = struct.pack('<I', len(self.data)).encode('hex')" wide nocase
        $Main_action7 = "Data = self.data.encode('hex')" wide nocase
        $Main_action8 = "OrgPathWLen = struct.pack('<I', len(self.datapath)).encode('hex')" wide nocase
        $Main_action9 = "OrgPathW = self.datapath.encode('utf-16le').encode('hex')" wide nocase
        $Main_action10 = "LabelLen = struct.pack('<I', len(self.filename)).encode('hex')" wide nocase
        $Main_action11 = "LabelW = self.filename.encode('utf-16le').encode('hex')" wide nocase
        $Main_action12 = "DefPathWLen = struct.pack('<I', len(self.orgpath)).encode('hex')" wide nocase
        $Main_action13 = "DefPathW = self.orgpath.encode('utf-16le').encode('hex')" wide nocase
		$Create_rtf = " ole1 = create_ole_exec_primitive('cmd.exe /c%tmp%\\{}'.format(os.path.basename(executable)), OBJDATA_TEMPLATE_0802, (0xd12*2), 126)"
		$Command = "hex_command = command.ljust(max_len).encode('hex')" nocase
    	$Command1 = "objdata_hex_stream = objdata_template.translate(None, '\r\n')" nocase
    	$Command2 = "ole_data = objdata_hex_stream[:command_offset] + hex_command + objdata_hex_stream[command_offset + len(hex_command):]" nocase
		$header_and_shellcode = /03010[0-1]([0-9a-fA-F]){4}([0-9a-fA-F]+08)([0-9a-fA-F]{4})([0-9a-fA-F]{296})2500/ ascii nocase
	condition:
		all of them

}	


