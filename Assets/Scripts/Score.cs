using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {
    private int _score = 0;
    private int _deficit = 0;

    public void incScore() {
        _score++;
    }

    public int getScore() {
        return _score;
    }

    //public int Deficit() {

    //}
}
