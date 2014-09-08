using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {


	public GameObject game;

	void OnMouseDown(){
		if (game.activeSelf)
			print ("Already playing");
		else
			game.SetActive (true);
	}
}
