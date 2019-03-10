 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngineInternal;

[System.Serializable] //so all our variables will show up in inspector
public class Word {
    public string word;
    private int index = 0;

    public Word(string word) 
    {
        this.word = word;
        index = 0;
    }

    public char GetNextLetter() {
        //this is required, because this Word object never gets deleted, it just gets saved to a list in WordManager, 
        //so if this word was completed once, it will start from index 5
        if (index >= 5) {
            index = 0;
        }

        Debug.Log("Inside Word: " + word + "index is " + index);
        //loop back if needed to?

        return word[index++];
    }

    //useless function?
    public void TypeLetter() {
        index++;
        //remove letter from onscreen
    }

    public bool Completed() {
        bool wordCompleted = (index >= word.Length) ? true : false;

        if (wordCompleted) {
            //remove word
            Debug.Log("This word was completed: " + word);
        }

        return wordCompleted;
    }

}

