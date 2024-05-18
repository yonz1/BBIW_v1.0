import "pe"
import "hash"
import "math"

rule Adwind
{
	meta:
		Action = "Valeur de Hash pour des menaces connues"
	 
	condition:
		hash.sha256(0, filesize) == "8993780d396d3f787eac06d59062d6c9f072e9639e10545b5655bf06fc55827b" or 
		hash.sha256(0, filesize) == "11054aa4170990ad1d345a2caf15285f3157e4bf240015cc20431b7373a52fc2" or
		hash.sha256(0, filesize) == "78c22b0bdb48269bf06e521c6dd960616eda9fa8592a81591a4b49f8f1c1162a" or
		hash.sha256(0, filesize) == "0cf873f1cb546239aca250821adff0482a746736e0a47887416a0d7a8c13085b" or
		hash.sha256(0, filesize) == "df24b51772ff4959e9bbfe481f72f0e88ba6e7c031d60edb3b1a47c69f69a6d0" or
		hash.sha256(0, filesize) == "dc1c478b9929c6c826a534845e8274896943ff399bdc042b767b924f16a75a3b" or
		hash.sha256(0, filesize) == "655954e2d7d2e71f7c2cdcfb278f9154b94a50904ee3315824de204aa14e0100" 
}


rule crimson 
{
	meta:
		Action = "valeur de hash pour des menaces connues"


	condition:
		hash.sha256(0, filesize) == "6b5f7abb7b99d3b1c46097ed1eb474732a125bc31ff429ed1a438beb4b01ac3c" or 
		hash.sha256(0, filesize) == "3c03f68788903ed2359d0476934cdbad8eb7ae4fb7472f25e5f354b25d7880ae" or
		hash.sha256(0, filesize) == "00e89eddc18f9bbc93c4c8b204ab3010bbb62a4f237a823e7926c4b1cec1067b" or
		hash.sha256(0, filesize) == "d046e766c9c755c88427a91d0dfcfca5659ade83bfd346315aeebc52c485208e" or
		hash.sha256(0, filesize) == "e4fd6452566102631a74d55b5a74b3fc5a2b7431144fb0ecf9f9fe64489a7409" or
		hash.sha256(0, filesize) == "3406b7fee0e95bbd0ab61954337edc6da91951cf9b04f18432ac85a78ddc3fcd" or
		hash.sha256(0, filesize) == "b4819738a277090405f0b5bbcb31d5dd3115f7026401e5231df727da0443332a" or
		hash.sha256(0, filesize) == "6dc0e565498e4f03c75f9d4e7824534e7121eab29b0cae8133f9bacb9ba749d4" or
		hash.sha256(0, filesize) == "33efd821e2484eda83e99247859286a78c16be9deea18bc1e563ad91cb789ea5" or
		hash.sha256(0, filesize) == "33a4a318e23bad0f912d093855043066ac0dce41fdd08c478a67772dc71260be" or
		hash.sha256(0, filesize) == "7d834e9caaaadd4f7e43777873550dd195d552038e7bd7ce4319f5cd51ed5c9d" or
		hash.sha256(0, filesize) == "4cc6d57785b80ece1e7734940da39b7bcc22993c83c2fe78794d52aa69c93234" or
		hash.sha256(0, filesize) == "9f6ee25ada84e57739fe3e29306bbc45b9df667bd1628e3dd1a0c2891c3deb92" or
		hash.sha256(0, filesize) == "8b1fe0fe0a20f8ce383a2713e170f91791ee6f62915dff86fb9e070965a7be23" or
		hash.sha256(0, filesize) == "d2c46e066ff7802cecfcb7cf3bab16e63827c326b051dc61452b896a673a6e67" or
		hash.sha256(0, filesize) == "7afde436f24f7faceb786554857c0fef6ceefebd1be0fcd4e68542e5a2ff0c8e" or
		hash.sha256(0, filesize) == "8f01ae46434e75207d29bc6de069b67c350120a9880cc8e30fefc19471eaac4a" or
		hash.sha256(0, filesize) == "2a6a8b7f07c3a36850dff4122427a954416e78f0454c7d8e715076ce75e68efd" or
		hash.sha256(0, filesize) == "04dc459acff73057a3f2abb885b05739057cad48c3cb51a54199c04b0f20972d" or
		hash.sha256(0, filesize) == "fa0b098f461c7e4e2056e94123ab5909e2d54c9a58d65112fdd663bc5c28aa31" 
}

rule warzone
{
	meta:
		Action = "valeur de hash pour des menaces connues"

	condition:
		hash.sha256(0, filesize) == "6a6e1823ba802e69315de8833ea7038289a51cb28f330fb359dc821d4923408c" or 
		hash.sha256(0, filesize) == "6a6e1823ba802e69315de8833ea7038289a51cb28f330fb359dc821d4923408c" or 
		hash.sha256(0, filesize) == "bd709aae771a9302a7b68c87f753386c08152cb912dc2ae6af968cc280ca9469" or 
		hash.sha256(0, filesize) == "775d65587d7e4ba50ec7e8b0519967d92ac50fd15586378a338cc24e3d90d18e" or 
		hash.sha256(0, filesize) == "f3617039d91185cb87c871b81601241371570366e47992c94434f494e3133648" or 
		hash.sha256(0, filesize) == "934476f737c735abecd92b010cd9f7bfdeb2beea5398df162a58cfbd163bccfa" or 
		hash.sha256(0, filesize) == "a7c3f81b96b812cd089fc6c1f036218c6f2842bb4076f51865b64a7d914305b3" or 
		hash.sha256(0, filesize) == "ef5b814562290c60063075b290966060a79e0cc9e81cd6448d49af5c5879175f" or 
		hash.sha256(0, filesize) == "4160d9f019f270da35ccb0d7242b7495ae64ad94e3a413c7bb8e6800592e7c63" or 
		hash.sha256(0, filesize) == "2a8b6d3293f3094c8988befb6081d9f8d193e216a82cc65abc1caaf520f3acc1" or 
		hash.sha256(0, filesize) == "8c9295644225155f6137dd31973a570434ec6490cada3598425f224a863849ad" or 
		hash.sha256(0, filesize) == "379075afc9fdb55dfb7c2f31a2a73168c5c852f2128584b9a259209df3641f0d" or 
		hash.sha256(0, filesize) == "e79d8f673fcb6e0b03601f2a5dfba4f2928d0f04b235311abd53277d3378e3e9" or 
		hash.sha256(0, filesize) == "584ce9956690cdee5fc287e37ecdd55b749cf4971ec97ae169dc29fac2da9d1a" or 
		hash.sha256(0, filesize) == "1cedc10c208cbbb3f9b46626b2026bd8c935773c49c33bf1042b2810908c58a0" or 
		hash.sha256(0, filesize) == "8a7ea6fa92042a82b6ee354c055e8579dd08bdf297aa5c0b54346405afca76be" or 
		hash.sha256(0, filesize) == "38af759cbc6513d04d12de480a4554bc4b1ac50124b8a7c0174e22b7ea1ec2ae" or 
		hash.sha256(0, filesize) == "6305f4ceffad6375145ef25069d6765ba216db16f2d77e1baec8692dc74ba712" or 
		hash.sha256(0, filesize) == "6f181edeb75819f2ad6e7eb97d8b05a63d143143ca2e0b6cd0030afc4a778df1" or 
		hash.sha256(0, filesize) == "167d71a6a442391712d666ed3b072bf45e6208333d460c0a34d059321d06ef9f" or 
		hash.sha256(0, filesize) == "44cb8052bd5df93d25f6d62b1ff50ed1289fbed59aafcc51579df9f547caaf47"
}