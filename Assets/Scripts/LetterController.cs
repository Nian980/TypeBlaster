using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterController : MonoBehaviour {

    public float mMoveSpeed;

	// Use this for initialization
	void Start () {
        mMoveSpeed = 10.0f;
	}
	
	// Update is called once per frame
	void Update () {
        //move forward x-direciton of WORLD SPACE.
        //Note that I rotated this object, so this object's x is not the world's x
        transform.Translate(mMoveSpeed * Time.deltaTime, 0.0f, 0.0f, Space.World);

        if (transform.position.x > 0) {
            //gameObject is the GameObject this component is attached to. ALL COMPONENTS will be attached to one.
            //note that calling Destroy(this) will actualy delete this script
            Destroy(gameObject);
        }
	}

    //public void Delete() {
    //    Destroy(gameObject);
    //}
}
