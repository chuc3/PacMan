using UnityEngine;
using System.Collections;

public class RestartLevel : MonoBehaviour {


	void OnMouseDown(){
		Application.LoadLevel ("Scene2");
	}
}
