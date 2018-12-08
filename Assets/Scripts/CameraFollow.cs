using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float speed = 2.0f;

    private GameObject player;
    private float initialCameraZ = 0.0f;

    private void Start()
    {
        // We store the camera's initial position...
        initialCameraZ = this.transform.localPosition.z;

        // Get a reference to the Player...
        if (player == null)
            player = GameObject.FindWithTag("Player");
    }

    private void Update()
    {
        float interpolation = speed * Time.deltaTime;

        // Animate the camera to follow the player...
        Vector3 position = this.transform.position;
        position.z = Mathf.Lerp(this.transform.position.z, player.transform.position.z + initialCameraZ, interpolation);
        this.transform.position = position;
    }

}