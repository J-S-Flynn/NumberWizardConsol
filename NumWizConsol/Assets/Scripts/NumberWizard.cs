using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

	int max = 1000;
	int min = 1;
	int guess = 500; 
	
	// Use this for initialization
	private void Start () {

	    
		
		Debug.Log("Hello  Welcome to number Wizard!");
		
		Debug.Log("we would like you to pick a number, but don't tell me what it is \n\n " +
		          "Highest number is : " + max + " \n\n " +
		          "Lowest Number is : " + min + "\n\n" +
		          "頑張って \n" );
		
		Debug.Log("Is it higher of lower than : " + guess);
		Debug.Log("Push up for higher \n " +
		          "Push down for lower \n" +
		          "push enter for correct! \n");
			
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.UpArrow)){
			Debug.Log("Its Higher");

			min = guess; 
			
			Debug.Log("New Guess : " + guess);
		}
		else if (Input.GetKeyDown(KeyCode.DownArrow)){
			Debug.Log("Its lower");

			max = guess; 
			Debug.Log("New Guess : " + guess);
		}
		else if (Input.GetKeyDown(KeyCode.Return)){
			Debug.Log("I Got it ");
			
			
		}
	}
}
