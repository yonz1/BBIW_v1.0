import "pe"
import "hash"
import "math"

rule Dangerous_function {
	meta:
		Action = "Fonctions pouvant être détourner si elle ne sont pas utiliser dans le contexte d'un programme ou logiciel officiel et vérifier"
	strings:
		$API1 = "GetExtendedTcpTable"		
		$API2 = "NetServerGetInfo"
		$reg = "dllhost.dat"
		$API7 = "perfc.dat"		
		$API8 = "CryptGenRandom"
		$File = "lsass.exe"
		$file = "lsasrv.dll"
	condition:
		any of them 
}

rule score_py {
	meta:
		Action = "Fonctions pouvant être détourner si elle ne sont pas utiliser dans le contexte d'un programme ou logiciel officiel et vérifier" 
	strings:
		$func1 = "key = Fernet.generate_key()" wide
		$func2 = "system('pip install -r requirements.txt')" 
		$func3 = " encrypt = f.encrypt(orginal)" wide
		$func4 = "decrypt = token.decrypt(encrypted)" wide
		$func5 = "token = Fernet(key)" wide
		$func6 = "from cryptography.fernet import Fernet" wide
		$func7 = "keyfile.write(key)" 
	condition:
		any of them
}

rule MD5_API {
	meta:
		Action = "Fonctions pouvant être détourner si elle ne sont pas utiliser dans le contexte d'un programme ou logiciel officiel et vérifier" 
	strings:
		$advapi32 = "advapi32.dll" wide ascii nocase
		$cryptdll = "cryptdll.dll" wide ascii nocase
		$MD5Init = "MD5Init" wide ascii
		$MD5Update = "MD5Update" wide ascii
		$MD5Final = "MD5Final" wide ascii
	condition:
		($advapi32 or $cryptdll) and ($MD5Init and $MD5Update and $MD5Final)
}

rule python_encryption{

	meta:
		Action = "Fonctions pouvant être détourner si elle ne sont pas utiliser dans le contexte d'un programme ou logiciel officiel et vérifier" 

	strings:
		$Libraries1 = "PyCryptodome"
		$Libraries2 = "M2Crypto"
		$Libraries3 = "PyOpenSSL"
		$Libraries4 = "asn1crypto"
		$Libraries5 = "Keyczar"
		$Libraries6 = "Fernet"
		$Libraries7 = "from cryptography.fernet import Fernet" wide
	condition:
		all of them
}

rule c_encryption{
	meta:
		Action = "Fonctions pouvant être détourner si elle ne sont pas utiliser dans le contexte d'un programme ou logiciel officiel et vérifier" 
	strings:
		$func = "int crypto_sign_keypair(unsigned char *pk, unsigned char *sk);"
		$Import = "libsodium"
		$Key = "int crypto_kx_keypair(unsigned char pk[crypto_kx_PUBLICKEYBYTES],unsigned char sk[crypto_kx_SECRETKEYBYTES]);" wide
	condition:
		any of them	
}

rule cpp_encryption {
	meta:
		Action = "Fonctions pouvant être détourner si elle ne sont pas utiliser dans le contexte d'un programme ou logiciel officiel et vérifier" 
	strings:
		$Import1 = "#ifndef CRYPTOPP_AES_H #define CRYPTOPP_AES_H" wide
	condition:
		any of them
}

rule register {
	meta:
		Action = "Fonctions pouvant être détourner si elle ne sont pas utiliser dans le contexte d'un programme ou logiciel officiel et vérifier" 
	strings:
		$Shadow_prompt = {72 65 67 2E 65 78 65 20 61 64 64 20 27 48 4B 4C 4D 5C 53 6F 66 74 77 61 72 65 5C 50 6F 6C 69 63 69 65 73 5C 4D 69 63 72 6F 73 6F 66 74 5C 57 69 6E 64 6F 77 73 20 4E 54 5C 54 65 72 6D 69 6E 61 6C 20 53 65 72 76 69 63 65 73 27 20 2F 56 20 53 68 61 64 6F 77 20 2F 54 20 52 45 47 5F 44 57 4F 52 44 20 2F 44 20 32 20 2F 46}
		$RDP_modifier1 = {72 65 67 2E 65 78 65 27 20 64 65 6C 65 74 65 20 27 48 4B 45 59 5F 43 55 52 52 45 4E 54 5F 55 53 45 52 5C 53 6F 66 74 77 61 72 65 5C 4D 69 63 72 6F 73 6F 66 74 5C 54 65 72 6D 69 6E 61 6C 20 53 65 72 76 65 72 20 43 6C 69 65 6E 74 5C 53 65 72 76 65 72 73 27 20 2F 66}
		$RDP_modifier2 = {72 65 67 2E 65 78 65 27 20 64 65 6C 65 74 65 20 27 48 4B 45 59 5F 43 55 52 52 45 4E 54 5F 55 53 45 52 5C 53 6F 66 74 77 61 72 65 5C 4D 69 63 72 6F 73 6F 66 74 5C 54 65 72 6D 69 6E 61 6C 20 53 65 72 76 65 72 20 43 6C 69 65 6E 74 5C 44 65 66 61 75 6C 74 27 20 2F 76 61 20 2F 66}
		$RDP_modifier3 = "48 4B 4C 4D 5C 53 59 53 54 45 4D 5C 43 75 72 72 65 6E 74 43 6F 6E 74 72 6F 6C 53 65 74 5C 43 6F 6E 74 72 6F 6C 5C 54 65 72 6D 69 6E 61 6C 20 53 65 72 76 65 72 5C 57 69 6E 53 74 61 74 69 6F 6E 73 5C 52 44 50 2D 54 63 70 27 20 2D 6E 61 6D 65 20 22 [1 - 10] 22 20 2D 56 61 6C 75 65 20 24 [1 - 10]"
		$Credentials1 = {72 65 67 20 61 64 64 20 27 48 4B 45 59 5F 4C 4F 43 41 4C 5F 4D 41 43 48 49 4E 45 5C 53 59 53 54 45 4D 5C 43 75 72 72 65 6E 74 43 6F 6E 74 72 6F 6C 53 65 74 5C 43 6F 6E 74 72 6F 6C 5C 53 65 63 75 72 69 74 79 50 72 6F 76 69 64 65 72 73 5C 57 44 69 67 65 73 74 27 20 2F 76 20 55 73 65 4C 6F 67 6F 6E 43 72 65 64 65 6E 74 69 61 6C 20 2F 74 20 52 45 47 5F 44 57 4F 52 44 20 2F 64 20 31}
		$Credentials2 = {72 65 67 20 71 75 65 72 79 20 27 48 4B 45 59 5F 43 55 52 52 45 4E 54 5F 55 53 45 52 5C 53 6F 66 74 77 61 72 65 5C [1 - 20]5C 50 75 74 74 79 5C 53 65 73 73 69 6F 6E 73 27}
		$User = {72 65 67 20 61 64 64 20 27 48 4B 45 59 5F 4C 4F 43 41 4C 5F 4D 41 43 48 49 4E 45 5C 53 6F 66 74 77 61 72 65 5C 4D 69 63 72 6F 73 6F 66 74 5C 57 69 6E 64 6F 77 73 20 4E 54 5C 43 75 72 72 65 6E 74 56 65 72 73 69 6F 6E 5C 57 69 6E 6C 6F 67 6F 6E 5C 53 70 65 63 69 61 6C 41 63 63 6F 75 6E 74 73 5C 55 73 65 72 6C 69 73 74 27 20 2F 76 20 75 73 65 72 20 2F 74 20 52 45 47 5F 44 57 4F 52 44 20 2F 64 20 31 20 2F 66}
		$Uninstall = {48 4B 45 59 5F 43 4C 41 53 53 45 53 5F 52 4F 4F 54 5C 44 69 72 65 63 74 6F 72 79 5C 73 68 65 6C 6C 65 78 5C 45 50 50}
		$Remove_defender = {72 65 67 20 61 64 64 20 48 4B 45 59 5F 43 55 52 52 45 4E 54 5F 55 53 45 52 5C 53 6F 66 74 77 61 72 65 5C 4D 69 63 72 6F 73 6F 66 74 5C 57 69 6E 64 6F 77 73 5C 43 75 72 72 65 6E 74 56 65 72 73 69 6F 6E 5C 50 6F 6C 69 63 69 65 73 5C 45 78 70 6C 6F 72 65 72 20 2F 76 20 22 53 65 74 74 69 6E 67 73 50 61 67 65 56 69 73 69 62 69 6C 69 74 79 22 20 2F 74 20 52 45 47 5F 44 57 4F 52 44 20 2F 64 20 22 68 69 64 65 3A 77 69 6E 64 6F 77 73 64 65 66 65 6E 64 65 72 22 20 2F 66}
		$Task_manager = {48 4B 45 59 5F 43 55 52 52 45 4E 54 5F 55 53 45 52 5C 53 4F 46 54 57 41 52 45 5C 4D 69 63 72 6F 73 6F 66 74 5C 57 69 6E 64 6F 77 73 5C 43 75 72 72 65 6E 74 56 65 72 73 69 6F 6E 5C 50 6F 6C 69 63 69 65 73 5C 53 79 73 74 65 6D 5C 64 69 73 61 62 6C 65 74 61 73 6B 6D 67 72}
		$explorer_bar = {48 4B 45 59 5F 43 55 52 52 45 4E 54 5F 55 53 45 52 5C 53 4F 46 54 57 41 52 45 5C 4D 69 63 72 6F 73 6F 66 74 5C 57 69 6E 64 6F 77 73 5C 43 75 72 72 65 6E 74 56 65 72 73 69 6F 6E 5C 50 6F 6C 69 63 69 65 73 5C 4E 6F 52 75 6E}
		$cmd = {72 65 67 20 61 64 64 20 48 4B 45 59 5F 43 55 52 52 45 4E 54 5F 55 53 45 52 5C 53 6F 66 74 77 61 72 65 5C 50 6F 6C 69 63 69 65 73 5C 4D 69 63 72 6F 73 6F 66 74 5C 57 69 6E 64 6F 77 73 5C 53 79 73 74 65 6D 20 2F 76 20 22 44 69 73 61 62 6C 65 43 4D 44 22 20 2F 74 20 52 45 47 5F 44 57 4F 52 44 20 2F 64 20 22 31 22 20 2F 66}
		$Privesc = {72 65 67 20 71 75 65 72 79 20 22 48 4B 4C 4D 5C 53 4F 46 54 57 41 52 45 5C 50 6F 6C 69 63 69 65 73 5C 4D 69 63 72 6F 73 6F 66 74 5C 57 69 6E 64 6F 77 73 5C 49 6E 73 74 61 6C 6C 65 72 5C 41 6C 77 61 79 73 49 6E 73 74 61 6C 6C 45 6C 65 76 61 74 65 64 22}
	condition:
		any of them
}

rule Hunting_Rule_ShikataGaNai
{
    meta:
        author = "Steven Miller"
	Action = "Systéme de cryptage avancée, très répandu, utilisable via Metasploit"
    strings:
        $varInitializeAndXorCondition1_XorEAX = { B8 ?? ?? ?? ?? [0-30] D9 74 24 F4 [0-10] ( 59 | 5A | 5B | 5C | 5D | 5E | 5F ) [0-50] 31 ( 40 | 41 | 42 | 43 | 45 | 46 | 47 ) ?? }
        $varInitializeAndXorCondition1_XorEBP = { BD ?? ?? ?? ?? [0-30] D9 74 24 F4 [0-10] ( 58 | 59 | 5A | 5B | 5C | 5E | 5F ) [0-50] 31 ( 68 | 69 | 6A | 6B | 6D | 6E | 6F ) ?? }
        $varInitializeAndXorCondition1_XorEBX = { BB ?? ?? ?? ?? [0-30] D9 74 24 F4 [0-10] ( 58 | 59 | 5A | 5C | 5D | 5E | 5F ) [0-50] 31 ( 58 | 59 | 5A | 5B | 5D | 5E | 5F ) ?? }
        $varInitializeAndXorCondition1_XorECX = { B9 ?? ?? ?? ?? [0-30] D9 74 24 F4 [0-10] ( 58 | 5A | 5B | 5C | 5D | 5E | 5F ) [0-50] 31 ( 48 | 49 | 4A | 4B | 4D | 4E | 4F ) ?? }
        $varInitializeAndXorCondition1_XorEDI = { BF ?? ?? ?? ?? [0-30] D9 74 24 F4 [0-10] ( 58 | 59 | 5A | 5B | 5C | 5D | 5E ) [0-50] 31 ( 78 | 79 | 7A | 7B | 7D | 7E | 7F ) ?? }
        $varInitializeAndXorCondition1_XorEDX = { BA ?? ?? ?? ?? [0-30] D9 74 24 F4 [0-10] ( 58 | 59 | 5B | 5C | 5D | 5E | 5F ) [0-50] 31 ( 50 | 51 | 52 | 53 | 55 | 56 | 57 ) ?? }
        $varInitializeAndXorCondition2_XorEAX = { D9 74 24 F4 [0-30] B8 ?? ?? ?? ?? [0-10] ( 59 | 5A | 5B | 5C | 5D | 5E | 5F ) [0-50] 31 ( 40 | 41 | 42 | 43 | 45 | 46 | 47 ) ?? }
        $varInitializeAndXorCondition2_XorEBP = { D9 74 24 F4 [0-30] BD ?? ?? ?? ?? [0-10] ( 58 | 59 | 5A | 5B | 5C | 5E | 5F ) [0-50] 31 ( 68 | 69 | 6A | 6B | 6D | 6E | 6F ) ?? }
        $varInitializeAndXorCondition2_XorEBX = { D9 74 24 F4 [0-30] BB ?? ?? ?? ?? [0-10] ( 58 | 59 | 5A | 5C | 5D | 5E | 5F ) [0-50] 31 ( 58 | 59 | 5A | 5B | 5D | 5E | 5F ) ?? }
        $varInitializeAndXorCondition2_XorECX = { D9 74 24 F4 [0-30] B9 ?? ?? ?? ?? [0-10] ( 58 | 5A | 5B | 5C | 5D | 5E | 5F ) [0-50] 31 ( 48 | 49 | 4A | 4B | 4D | 4E | 4F ) ?? }
        $varInitializeAndXorCondition2_XorEDI = { D9 74 24 F4 [0-30] BF ?? ?? ?? ?? [0-10] ( 58 | 59 | 5A | 5B | 5C | 5D | 5E ) [0-50] 31 ( 78 | 79 | 7A | 7B | 7D | 7E | 7F ) ?? }
        $varInitializeAndXorCondition2_XorEDX = { D9 74 24 F4 [0-30] BA ?? ?? ?? ?? [0-10] ( 58 | 59 | 5B | 5C | 5D | 5E | 5F ) [0-50] 31 ( 50 | 51 | 52 | 53 | 55 | 56 | 57 ) ?? }
		// Obtenir la clé, Obtenir le EIP, Décoder, Préparer le prochain code
	condition:
        any of them
}

rule Bypass
{
	meta:
		Action = "Fonctions pouvant être détourner si elle ne sont pas utiliser dans le contexte d'un programme ou logiciel officiel et vérifier" 
	strings:
		$Py2 = {20 2B 3D 20 63 68 72 28 6F 72 64 28 [1 - 20] 5B 69 5D 29 20 5E 20 6F 72 64 28 [1 - 20] 5B 69 20 25 20 6C 65 6E 28 [1 - 20] 29 5D 29 29}
		$Py1 = {66 6F 72 20 69 20 69 6E 20 72 61 6E 67 65 28 6C 65 6E 28 [1 - 30] 29 29 3A}
		$bypass = "${IFS}"
	condition:
		($Py1 and $Py2) or $bypass
}









