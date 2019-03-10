using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMove : MonoBehaviour {

    public float mFloatSpeed = 0.5f;
    bool mMovingUp = true;

    private void Start()
    {
        mFloatSpeed = 0.5f;
        mMovingUp = true;
    }

    // Update is called once per frame
    void Update () {
        //transform.Translate(0.0f, mFloatSpeed * Time.deltaTime, 0.0f, Space.World);

        if (mMovingUp) //moving up
        {
            transform.Translate(0.0f, mFloatSpeed * Time.deltaTime, 0.0f, Space.World);
        }
        else if (!mMovingUp) //moving down
        {
            transform.Translate(0.0f, -mFloatSpeed * Time.deltaTime, 0.0f, Space.World);

        }

        if (transform.position.y < 0.5f) {
            mMovingUp = true;
        }
        else if (transform.position.y > 1.0f) {
            mMovingUp = false;
        }

    }
}
