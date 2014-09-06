using UnityEngine;
using System.Collections;

public class spawnWalls : MonoBehaviour {

	public Transform wall;
	public Transform pellet;
	public TextAsset map;

	void Awake(){
		Vector3 v = new Vector3 ();
		int i, j;i = 0;j = 0;
		v.y = 1;

		string [] lines = map.text.Split ('\n');
		foreach (string line in lines) 
		{
			foreach(char c in line)
			{
				if(c=='X'){
					v.x=i;v.z=j;
					Instantiate(wall,v,Quaternion.identity);
				}
				else if(c=='.'){
					v.x=i;v.z=j; v.y =2;
					Instantiate(pellet,v,Quaternion.identity);
					v.y = 1;
				}
				i+=1;
			}
			i=0;
			j-=1;
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
