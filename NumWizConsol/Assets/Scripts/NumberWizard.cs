using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	private void Start () {

	    int max = 1000;
		int min = 1; 
		
		Debug.Log("Hello  Welcome to number Wizard!");
		
		Debug.Log("we would like you to pick a number, but don't tell me what it is \n\n " +
		          "Highest number is : " + max + " \n\n " +
		          "Lowest Number is : " + min + "\n\n" +
		          "頑張って \n" );
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
