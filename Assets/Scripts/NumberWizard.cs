using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

    private int max;
    private int min;
    private int guess;

    public int maxGuessesAllowed = 10;
    public Text guessTextObj;

    // Use this for initialization
    void Start () {
        StartGame();
	}

    public void GuessHigher() {
        min = guess;
        UpdateGuess();
    }

    public void GuessLower() {
        max = guess;
        UpdateGuess();
    }

    private void StartGame()
    {
        max = 1000;
        min = 1;

        UpdateGuess();

        // Add one to max so we don't get stuck at 999 if the number is 1000.
        max = max + 1;
    }

    private void UpdateGuess()
    {
        guess = (max + min) / 2;
        guessTextObj.text = guess.ToString();

        maxGuessesAllowed -= 1;
        if (maxGuessesAllowed <= 0) {
            SceneManager.LoadScene("Win");
        }
    }
}
