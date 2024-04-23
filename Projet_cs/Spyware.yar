import "pe"
import "hash"
import "math"
import "console"

rule keylogger_cpp

{
	meta:
		author = "me"
	strings:
		$Charmap = "const std::map<int, std::string> keyname{ "
		$Callback = "LRESULT __stdcall HookCallback(int nCode, WPARAM wParam, LPARAM lParam)"
		$CrochetWindows = "if (!(_hook = SetWindowsHookEx(WH_KEYBOARD_LL, HookCallback, NULL, 0)))"
		$Capture1 = "threadID = GetWindowThreadProcessId(foreground, NULL);"
		$Capture2 = "layout = GetKeyboardLayout(threadID);"
		$Mappage = "key = MapVirtualKeyExA(key_stroke, MAPVK_VK_TO_CHAR, layout);"
		$Verification = "return GetSystemMetrics(SM_SYSTEMDOCKED) != 0;"
	condition:
		all of them 
}

rule Keylogger_py

{
	meta:
		author = "me"

	strings:
	$import = "import os"
        $Micro1 = "obj.setnchannels(1)"
        $Micro2 = "obj.setsampwidth(2)"
        $Micro3 = "obj.setframerate(fs)"
        $Micro4 = "myrecording = sd.rec(int(seconds * fs), samplerate=fs, channels=2)"
        $Micro5 = "obj.writeframesraw(myrecording)"
	$Info1 = "hostname = socket.gethostname()"
        $Info2 = "ip = socket.gethostbyname(hostname)"
        $Info3 = "plat = platform.processor()"
        $Info4 = "system = platform.system()"
        $Info5 = "machine = platform.machine()"
        $Mouse1 = "current_move = logging.info('Mouse moved to {} {}'.format(x, y))"
        $Mouse2 = "self.appendlog(current_move)"
	$Mouse3 = "current_click = logging.info('Mouse moved to {} {}'.format(x, y))"
        $Mouse4 = "self.appendlog(current_click)"
	$Mouse5 = "current_scroll = logging.info('Mouse moved to {} {}'.format(x, y))"
        $Mouse6 = "self.appendlog(current_scroll)"		
	condition:
		all of them or any of ($Mouse*) or any of ($Micro*)
}

rule keylogger_swift {
	meta:
		author = "me"

	strings:
	 	$Callback1 = "IOHIDManagerRegisterDeviceMatchingCallback(manager, CallBackFunctions.Handle_DeviceMatchingCallback, observer)"
        	$Callback2 = "IOHIDManagerRegisterDeviceRemovalCallback(manager, CallBackFunctions.Handle_DeviceRemovalCallback, observer)"
        	$Callback3 = "IOHIDManagerRegisterInputValueCallback(manager, CallBackFunctions.Handle_IOHIDInputValueCallback, observer);"
		$Input1 = "let resultAsSwiftDic = [kIOHIDDeviceUsagePageKey: inUsagePage, kIOHIDDeviceUsageKey : inUsage]"
        	$Input2= "let resultAsCFDic: CFMutableDictionary = resultAsSwiftDic as! CFMutableDictionary"
		$Loop1 = "IOHIDManagerScheduleWithRunLoop(manager, CFRunLoopGetMain(), CFRunLoopMode.defaultMode.rawValue)"
		$loop2 = "IOHIDManagerUnscheduleFromRunLoop(manager, CFRunLoopGetMain(), CFRunLoopMode.defaultMode.rawValue);"
	condition:
		all of them or any of ($Callback*)
}
