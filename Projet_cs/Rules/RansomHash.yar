import "pe"
import "hash"
import "math"

rule NotePetya
{
	meta:
		Action = "Valeur de Hash pour des menaces connues"
	condition:
		hash.sha256(0, filesize) == "eae9771e2eeb7ea3c6059485da39e77b8c0c369232f01334954fbac1c186c998" or 
		hash.sha256(0, filesize) == "eae9771e2eeb7ea3c6059485da39e77b8c0c369232f01334954fbac1c186c998" or 
		hash.sha256(0, filesize) == "02ef73bd2458627ed7b397ec26ee2de2e92c71a0e7588f78734761d8edbdcd9f" or 
		hash.sha256(0, filesize) == "f8dbabdfa03068130c277ce49c60e35c029ff29d9e3c74c362521f3fb02670d5" 
}

