import "pe"
import "math"
import "hash"



rule beepshellcode
{
	meta:
		author = "Bastien Pelle"
		description = ""

	strings: 
		$adrr1 = {5C 78 31 30 5C 78 43 39 5C 78 45 41 5C 78 37 37}
		$length1 = {22 5C 78 45 38 5C 78 30 33 22 20 20}
		$adrr2= {5C 78 35 33 5C 78 38 41 5C 78 38 33 5C 78 37 43}
		$lenght2= {5C 78 44 30 5C 78 30 33 20}
		$frequency1 = {5C 78 30 31 5C 78 30 45} 
		$beep = {62 65 65 70}
		
	
	condition:
		all of them
}

