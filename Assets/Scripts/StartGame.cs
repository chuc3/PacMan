using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {


	public GameObject game;

	void OnMouseDown(){
		game.SetActive (true);
	}
}
