using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour {

    void OnCollisionEnter(Collision col)
    {
     // Just destroy the GameObject that collided with us...
        Destroy(col.gameObject);
    }
}
