using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CharacterRoster : MonoBehaviour
{
	List<Character> roster;

	void Awake () 
	{
		roster = new List<Character> ();
	}

	public bool AddCharacter()
	{
		//read from a json file of character defaults
		return false;
	}

	public bool LoadCharacter()
	{
		//read from a json save file of character stats
		return false;
	}

	public bool LoadSylpha()
	{
		//test function just to load up a character
		Character temp_char = new Character("Sylpha");
		Captain starting_class = new Captain ();
		temp_char.UnitClass = starting_class;

		roster.Add(temp_char);
		return true;
	}

	//used for copying the roster over to the chapter roster at the start of a new chapter
	public List<Character> GetRoster()
	{
		return roster;
	}

	//copying over the changes in the chapter roster back to the master character roster
	public void SetRoster()
	{

	}
}


