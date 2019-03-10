using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Security.Policy;

public class WordGenerator : MonoBehaviour {

    public static string GetRandomWord() {
        char[] letters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'X' };

        string randomWord = "";

        //create 5 letter word
        for (int i = 0; i < 5; i++) 
        {
            int randomInd = Random.Range(0, 25);
            randomWord += letters[randomInd];
        }

        randomWord = randomWord.ToLower();

        return randomWord;
    }
}
