using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SimplePlayerController : MonoBehaviour
{

    public float tileSize = 10.0f;

    GameObject targetRotation;
    Vector3 targetPosition;

    AudioSource audioData;

    void Start()
    {     
        targetRotation = new GameObject();
        targetPosition = transform.position;
        audioData = GetComponent<AudioSource>();
    }

    void Update()
    {
       
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                targetPosition += Vector3.forward * tileSize;
                SetTargetRotation(0f);
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                targetPosition += Vector3.back * tileSize;
                SetTargetRotation(-180f);
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                targetPosition += Vector3.left * tileSize/2;
                SetTargetRotation(-90f);
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                targetPosition += Vector3.right * tileSize/2;
                SetTargetRotation(90f);
            }

            transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * 55f);
            transform.rotation = Quaternion.Lerp(this.transform.rotation, targetRotation.transform.rotation, Time.deltaTime * 30.1f);
    }

    void SetTargetRotation(float yRotation)
    {
        targetRotation.transform.rotation = Quaternion.identity;
        targetRotation.transform.Rotate(0, yRotation, 0);
        audioData.Play(0);
    }

}