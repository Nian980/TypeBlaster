using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordDisplay : MonoBehaviour {

    public GameObject mgameObject;
    public string mLetter;
    public float mMoveSpeed = 1f;

    public void SetLetter(string letter)
    {
        mLetter = letter;
    }

    public void RemoveLetter()
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update () {
        transform.Translate(0f, -mMoveSpeed * Time.deltaTime, 0f);
    }
}
