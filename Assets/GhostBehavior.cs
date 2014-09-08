using UnityEngine;
using System.Collections;

public class GhostBehavior : MonoBehaviour {

	int highscore;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		float speed = 10.0f;

		Vector3 vel = new Vector3();
		
		vel = Random.insideUnitSphere * speed;
		vel.y = 0.0f;
		transform.Translate (vel * Time.deltaTime);

	}
	void OnTriggerEnter (Collider other) {
		if (other.tag == "Player") {
			print ("END GAME");
			if(displayScore.the_score>PlayerPrefs.GetInt("High Score")){
				highscore = displayScore.the_score;
				PlayerPrefs.SetInt("High Score", highscore);
			}
			Application.LoadLevel("Scene2");
		}
	} 

}
