import "pe"
import "math"
import "hash"

rule Registry1
{
    meta:
		Actions = "registre contenant des information sensible ou importantes"

    strings:
        $malreg1 = {48 4B 45 59 5F 43 55 52 52 45 4E 54 5F 55 53 45 52 5C 53 6F 66 74 77 61 72 65 5C 4D 69 63 72 6F 73 6F 66 74 5C 57 69 6E 64 6F 77 73 5C 43 75 72 72 65 6E 74 56 65 72 73 69 6F 6E 5C 52 75 6E}
        $malreg2 = {48 4B 45 59 5F 43 55 52 52 45 4E 54 5F 55 53 45 52 5C 53 6F 66 74 77 61 72 65 5C 4D 69 63 72 6F 73 6F 66 74 5C 57 69 6E 64 6F 77 73 5C 43 75 72 72 65 6E 74 56 65 72 73 69 6F 6E 5C 52 75 6E 4F 6E 63 65}
        $malreg3 = {48 4B 45 59 5F 4C 4F 43 41 4C 5F 4D 41 43 48 49 4E 45 5C 53 6F 66 74 77 61 72 65 5C 4D 69 63 72 6F 73 6F 66 74 5C 57 69 6E 64 6F 77 73 5C 43 75 72 72 65 6E 74 56 65 72 73 69 6F 6E 5C 52 75 6E}
        $malreg4= {48 4B 45 59 5F 4C 4F 43 41 4C 5F 4D 41 43 48 49 4E 45 5C 53 6F 66 74 77 61 72 65 5C 4D 69 63 72 6F 73 6F 66 74 5C 57 69 6E 64 6F 77 73 5C 43 75 72 72 65 6E 74 56 65 72 73 69 6F 6E 5C 52 75 6E 4F 6E 63 65}
        $malreg5 = {48 4B 45 59 5F 4C 4F 43 41 4C 5F 4D 41 43 48 49 4E 45 5C 53 6F 66 74 77 61 72 65 5C 4D 69 63 72 6F 73 6F 66 74 5C 57 69 6E 64 6F 77 73 5C 43 75 72 72 65 6E 74 56 65 72 73 69 6F 6E 5C 52 75 6E 4F 6E 63 65 45 78}
        $malreg6 = {5C 41 70 70 44 61 74 61 5C 52 6F 61 6D 69 6E 67 5C 4D 69 63 72 6F 73 6F 66 74 5C 57 69 6E 64 6F 77 73 5C 53 74 61 72 74 20 4D 65 6E 75 5C 50 72 6F 67 72 61 6D 73 5C 53 74 61 72 74 75 70}
    condition:
        any of them
}

rule startup_item
{
    meta:
		Actions = "registre contenant des information sensible ou importantes"

    strings:
        $malregstart1 = {48 4B 45 59 5F 43 55 52 52 45 4E 54 5F 55 53 45 52 5C 53 6F 66 74 77 61 72 65 5C 4D 69 63 72 6F 73 6F 66 74 5C 57 69 6E 64 6F 77 73 5C 43 75 72 72 65 6E 74 56 65 72 73 69 6F 6E 5C 45 78 70 6C 6F 72 65 72 5C 55 73 65 72 20 53 68 65 6C 6C 20 46 6F 6C 64 65 72 73}
        $malregstart2 = {48 4B 45 59 5F 43 55 52 52 45 4E 54 5F 55 53 45 52 5C 53 6F 66 74 77 61 72 65 5C 4D 69 63 72 6F 73 6F 66 74 5C 57 69 6E 64 6F 77 73 5C 43 75 72 72 65 6E 74 56 65 72 73 69 6F 6E 5C 45 78 70 6C 6F 72 65 72 5C 53 68 65 6C 6C 20 46 6F 6C 64 65 72 73}
        $malregstart3 = {48 4B 45 59 5F 4C 4F 43 41 4C 5F 4D 41 43 48 49 4E 45 5C 53 4F 46 54 57 41 52 45 5C 4D 69 63 72 6F 73 6F 66 74 5C 57 69 6E 64 6F 77 73 5C 43 75 72 72 65 6E 74 56 65 72 73 69 6F 6E 5C 45 78 70 6C 6F 72 65 72 5C 53 68 65 6C 6C 20 46 6F 6C 64 65 72 73}
        $malregstart4 = {48 4B 45 59 5F 4C 4F 43 41 4C 5F 4D 41 43 48 49 4E 45 5C 53 4F 46 54 57 41 52 45 5C 4D 69 63 72 6F 73 6F 66 74 5C 57 69 6E 64 6F 77 73 5C 43 75 72 72 65 6E 74 56 65 72 73 69 6F 6E 5C 45 78 70 6C 6F 72 65 72 5C 55 73 65 72 20 53 68 65 6C 6C 20 46 6F 6C 64 65 72 73}

    condition:
        any of them
}




