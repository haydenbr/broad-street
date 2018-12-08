using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPaint : MonoBehaviour {

    // List of materials we can add through the Inspector...
    public Material[] paintMat;

	// Use this for initialization
	void Start () {

        // Get a reference to the Renderer...
        Renderer rend = GetComponent<Renderer>();

        // Set the Renderer's Material to one from the paintMat list.
        rend.material = paintMat[Random.Range(0, paintMat.Length)];

    }

}
