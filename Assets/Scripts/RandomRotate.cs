using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
        float fFlip = Random.Range(0.0f, 1.0f);
        if (fFlip >= 0.5f)
        {
            gameObject.transform.Rotate(0f, 180f, 0f);
        }
	}
	

}
