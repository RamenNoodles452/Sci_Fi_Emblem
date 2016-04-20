using UnityEngine;
using System.Collections;

public class GameLoader : MonoBehaviour 
{
	public GameObject GameState;

	// Use this for initialization
	void Start () 
	{
		DontDestroyOnLoad (GameState);
		GameState.GetComponent<CharacterRoster> ().LoadSylpha ();

		UnityEngine.SceneManagement.SceneManager.LoadScene ("Chapter-1");
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
