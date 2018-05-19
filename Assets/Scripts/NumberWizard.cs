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
    }

    private void UpdateGuess()
    {
        guess = Random.Range(min, max + 1);
        guessTextObj.text = guess.ToString();

        maxGuessesAllowed -= 1;
        if (maxGuessesAllowed <= 0) {
            SceneManager.LoadScene("Win");
        }
    }
}
