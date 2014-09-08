using UnityEngine;
using System.Collections;

public class eatPellet : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnTriggerEnter (Collider other) {
		if (other.tag == "nom") {
			displayScore.the_score++;
			Destroy (other.gameObject);
		} 

	}
}
