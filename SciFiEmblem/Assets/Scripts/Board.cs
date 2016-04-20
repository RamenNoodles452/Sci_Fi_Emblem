using UnityEngine;
using System.Collections;

public class Board : MonoBehaviour 
{
	public GameObject Map;

	public Vector2 grid_origin;
	const int SPACE_DIMENTIONS = 100;
	public GameObject[,] grid;

	// contains the list of unit prefabs to move around the board

	// Use this for initialization
	void Start () 
	{
		if (Map == null)
			throw new MissingReferenceException("Map object not assigned");
		
	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	void CalculateDimensions(int originx, int originy, int columns, int rows)
	{
		grid_origin = new Vector2(originx, originy);
		grid = new GameObject[columns, rows];
	}

	public void ChangeMap(int chapterNumber)
	{
		//-1 is test map
		if (chapterNumber == -1) 
		{
			Sprite test_map = Resources.Load<Sprite> ("Art/test_map");
			Map.GetComponent<SpriteRenderer>().sprite = test_map;

			CalculateDimensions (0, 0, 10, 10);
		}
	}
}
