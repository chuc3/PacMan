using UnityEngine;
using System.Collections;

public class displayHighscore : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.guiText.text = "High Score: " + PlayerPrefs.GetInt ("High Score").ToString();
	}
	
	// Update is called once per frame
	void Update () {
		if(PlayerPrefs.GetInt("High Score")<displayScore.the_score)
			gameObject.guiText.text = "High Score: " + displayScore.the_score;
	}
}
