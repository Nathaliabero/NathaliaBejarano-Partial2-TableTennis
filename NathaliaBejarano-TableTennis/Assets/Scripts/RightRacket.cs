using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightRacket : MonoBehaviour {

    public float MotionSpeed;
        
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.RightArrow)) {
     
            this.transform.Translate(Vector3.forward * MotionSpeed);
        }

        if (Input.GetKey(KeyCode.LeftArrow)) {
      
            this.transform.Translate(Vector3.back * MotionSpeed);
        }

        if (Input.GetKey(KeyCode.UpArrow)) {
       
            this.transform.Translate(Vector3.up * MotionSpeed);
        }

        if (Input.GetKey(KeyCode.DownArrow)) {
       
            this.transform.Translate(Vector3.down * MotionSpeed);
        }
    }
}
