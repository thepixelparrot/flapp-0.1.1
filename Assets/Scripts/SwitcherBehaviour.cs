using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitcherBehaviour : MonoBehaviour {

	// Use this for initialization
	public static GameController instance;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D (){
		if(gameObject.tag.Equals("EndBox") == true ){
           GameController.instance.BirdWin();
      	}
	}
}
