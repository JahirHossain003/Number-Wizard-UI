using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NumberWizards : MonoBehaviour {
	// Use this for initialization
	int max;
	int min;
	int guess;

	public Text text;

	public int maxGuessAllowed = 5;

	void Start () {
		StartGame();
	}
	
	void StartGame () {
		max = 1000;
		min = 1;
		guess = 500;


	}


	public void guessHigher(){
		min = guess;
		NextGuess();
	}

	public void guessLower(){
		max = guess;
		NextGuess();
	}


	void NextGuess () {
		guess = Random.Range(min,max+1);
		text.text = guess.ToString();
		maxGuessAllowed = maxGuessAllowed - 1;
		if(maxGuessAllowed <= 0){
			Application.LoadLevel("Win");
		}
	}
}
