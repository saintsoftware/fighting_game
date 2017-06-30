using UnityEngine;
using System.Collections;

public abstract class lists : MonoBehaviour
{
	
	//Configuring Arrays: type, first value  number of fields, second value number of entry's per field. 
	
	/* CHARACTERS
		Name
		Fighting Style
		Base Damage
	
	*/

    string[,] characters = new string[4, 3] { 
		{ "talia", "kung Fu", "10" },
		{ "", "", "" },
		{ "", "", "" },
		{ "", "", "" }
    };

	/* ABILITYS
		Name
		Extra Damage
		Description
		
	*/	
		
    string[,] abilitys = new string[2, 3] {
		{ "spinning kick", "45", "Character spinnes in the air hitting all near in a rotating way." },
		{ "", "", "" }

    };
	
	/* WEAPONS
		Name
		Extra Damage
	
	*/	
	
	string[,] weapons = new string[5, 3] {
		{ "club", "75", "10 intelect" },
		{ "baseball bat", "75", "5 armor" },
		{ "Chain", "75", "10 armor" }
    };
 
}
