using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    public float speed = 3;

    private void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

}
