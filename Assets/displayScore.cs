using UnityEngine;
using System.Collections;

public class displayScore : MonoBehaviour {

	public static int the_score;

	// Use this for initialization
	void Start () {
		the_score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.guiText.text = "Score: " + the_score;
	}
}
