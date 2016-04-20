using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ChapterInitializer : MonoBehaviour 
{
	GameObject _gameState;

	public GameObject ChapterBoard;
	Board _chapterBoard;
	int chapter_number = -1;

	// this is used to initialize the unit prefabs
	public List<Character> chapter_roster;

	// Use this for initialization
	void Start () 
	{
		if (ChapterBoard == null)
			throw new MissingReferenceException("Board object not assigned");
		_chapterBoard = ChapterBoard.GetComponent<Board> ();
		LoadMap (chapter_number);

		// assign the gamestate to a var so that we can reference it
		_gameState = GameObject.FindWithTag("GameController");

		// load up the chapter_roster from GameState.character_roster
		chapter_roster = _gameState.GetComponent<CharacterRoster>().GetRoster();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void LoadMap(int chapterNum)
	{
		//TODO: load chapter information from a json object that lists all chapter information
		if (chapterNum == -1) 
		{
			_chapterBoard.ChangeMap (chapterNum);
		}
	}
}
