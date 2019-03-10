using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class WordManager : MonoBehaviour {
    public List<Word> mWords;

    public Score mScore;

    public int totalWords = 20;

    private Word mActiveWord;
    public bool mHasActiveWord;

    //private Word mActiveChosenWord;

    public WordSpawner mWordSpawner;

    //List<Transform> letterIntances;
    public int letterIndex;

    public void Start()
    {
        letterIndex = 0;
        for (int i = 0; i < totalWords; i++)
        {
            AddWord();
        }
    }

    public void AddWord() 
    {
        Word newWord = new Word(WordGenerator.GetRandomWord());
        //Debug.Log(newWord.word);
        mWords.Add(newWord);
    }

    public void TypeLetter(char letter) 
    {
        //Debug.Log("list of letters looks like:");
        //for (int i = 0; i < 5; i++) {
        //    Debug.Log(mWordSpawner.letters[i]);
        //}

        Debug.Log("Letter typed = " + letter);

        //DEBUG
        if (mWordSpawner.letters.Count == 0) {
            Debug.Log("letters list is empty");
        }

        if (mHasActiveWord) {
            if (mActiveWord.GetNextLetter() == letter) {
                //Destroy(letterIntances[letterIndex].gameObject); //does this work? 

                Debug.Log("LetterIndex = " + letterIndex);

                //check for null, cuz the letters destroy themselves after going past, but still end up saved in list.
                if (mWordSpawner.letters[letterIndex] != null) { //if not null
                    Destroy(mWordSpawner.letters[letterIndex].gameObject);
                    letterIndex++;
                }

                //mActiveWord.TypeLetter();
            }
        }

        //typed all 5 letters
        if (letterIndex >= 5)
        {
            mHasActiveWord = false;
            mActiveWord = null; //ignore that word now
            letterIndex = 0;
        }

        //else { //else if no word active, get the next matching active word
        //    foreach (Word word in mWords) {
        //        if (word.GetNextLetter() == letter) {
        //            mActiveWord = word;
        //            Debug.Log("New active word: " + mActiveWord.word);
        //            mHasActiveWord = true;
        //            word.TypeLetter(); //remove that letter from that word
        //            break;
        //        }
        //    }
        //}

        //redundant code?
        //if we completely typed that word
        //if (mHasActiveWord && mActiveWord.Completed()) {
        //    mHasActiveWord = false;
        //    letterIndex = 0; //reset letter index to 0 to be ready for new word
        //    //mWords.Remove(mActiveWord);
        //}
    }

    //spawn a word every 5 seconds, assuming there isn't already an active word
    private float mTimer = 5.0f;

    void Update()
    {
        mTimer -= Time.deltaTime;

        if (mTimer <= 0.0f && !mHasActiveWord) //and does not already have an active word
        {
            //choose a word from mWords, then send it to wordspawner to spawn
            int randInd = UnityEngine.Random.Range(0, mWords.Count - 1);
            Word chosenWord = mWords[randInd];

            mHasActiveWord = true;
            mActiveWord = chosenWord;

            //makes it easeir, removes from the master list words, don't have to deal with it again
            mWords.Remove(chosenWord);

            Debug.Log("Spawning the word: " + chosenWord.word + "!");

            //set to new set of letterInstances each time a new word comes
            //letterIntances = 
            mWordSpawner.SpawnWord(chosenWord.word); //spawn that chosen word

            mTimer = 5.0f;
        }

        //if after another 5 seconds haven't typed all words, by now they must've all gone past
        if (mTimer <= -5.0f) {
            //just quit that word, no more active word, reset timer
            mHasActiveWord = false;
            mActiveWord = null; //ignore that word now
            mTimer = 5.0f;
        }

        //loop letter index back to 0 here if needed
        if (letterIndex >= 5) {
            mHasActiveWord = false;
            mActiveWord = null; //ignore that word now
            letterIndex = 0; 
        }
    }
}
