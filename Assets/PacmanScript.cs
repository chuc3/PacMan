using UnityEngine;
using System.Collections;

public class PacmanScript : MonoBehaviour {

	float curr_time;
	bool openMouth;
	Transform child1;
	Transform child2;

	void switch_layers(){

		if (openMouth){
			child1.gameObject.SetActive(false);
			child2.gameObject.SetActive(true);
		} 
		else {
			child1.gameObject.SetActive(true);
			child2.gameObject.SetActive(false);
		}
	}
	void rotate_pac()
	{
		if(Input.GetKeyDown(KeyCode.A)||Input.GetKeyDown(KeyCode.LeftArrow))
		{
			transform.GetChild(0).localEulerAngles=new Vector3(0,180,0);
		}
		if(Input.GetKeyDown(KeyCode.D)||Input.GetKeyDown(KeyCode.RightArrow))
		{
			transform.GetChild(0).localEulerAngles=new Vector3(0,0,0);
		}
		if(Input.GetKeyDown(KeyCode.W)||Input.GetKeyDown(KeyCode.UpArrow))
		{
			transform.GetChild(0).localEulerAngles=new Vector3(0,270,0);
		}
		if(Input.GetKeyDown(KeyCode.D)||Input.GetKeyDown(KeyCode.DownArrow))
		{
			transform.GetChild(0).localEulerAngles=new Vector3(0,90,0);
		}
	}
	// Use this for initialization
	void Start () {
		curr_time = 0f;
		child1 = transform.GetChild (0).GetChild(0);
		child2 = transform.GetChild (0).GetChild(1);
		openMouth=false;
	}
	
	// Update is called once per frame
	void Update () {
		curr_time += Time.deltaTime ;
		if (curr_time >= .5f) {
			openMouth= !openMouth;
			curr_time = 0f;
			switch_layers();
		}
		rotate_pac ();
	}

}
