using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public GameManager gameManager;
    public float tileSize = 10.0f;
    int currentRow = 1;
    int currentColumn = 0;
    int latestRowReached = 0;

    GameObject targetRotation;
    Vector3 targetPosition;

    AudioSource audioData;

  /*
    // Comment this block out...
    public Transform waterTransform;
    Vector3 waterPosition;

    public GameObject SplashObject;
    public RowSpawner rowSpawner;
    // End block
  */


    bool canUpdate = true;

    void Start()
    {     
        targetRotation = new GameObject();
        targetPosition = transform.position;
       // waterPosition = waterTransform.position;
        audioData = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (!canUpdate) return;

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                currentRow++;
                targetPosition += Vector3.forward * tileSize;
                SetTargetRotation(0f);

                /*
                   // Comment this block out...
                if (currentRow > latestRowReached)
                {

                   waterPosition.z = waterTransform.position.z + tileSize;
                   waterTransform.position = waterPosition;
                   latestRowReached = currentRow;
                   gameManager.SetScore(gameManager.GetScore() + 10);
                   rowSpawner.SpawnStrip();
                   if (currentRow > 8)
                   {
                       rowSpawner.DeleteFirstStrip();
                   }
                  
               }
             // End block
             */

        }

        if (Input.GetKeyDown(KeyCode.DownArrow) && currentRow > 1)
            {
                currentRow--;
                targetPosition += Vector3.back * tileSize;
                SetTargetRotation(-180f);
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow) && currentColumn > -10)
            {
                currentColumn--;
                targetPosition += Vector3.left * tileSize/2;
                SetTargetRotation(-90f);
            }

            if (Input.GetKeyDown(KeyCode.RightArrow) && currentColumn < 10)
            {
                currentColumn++;
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

   /*
    // =====================================================================
    // Collision Section ===================================================

    private void OnTriggerStay(Collider other)
    {
        // Player hits the water...
        if (other.gameObject.tag == "Water" && canUpdate == true)
        {
            canUpdate = false;
            gameObject.GetComponent<Rigidbody>().useGravity = true;
            gameObject.GetComponent<Rigidbody>().isKinematic = false;

            StartCoroutine(FallInWater());
        }

    }

    IEnumerator FallInWater()
    {
        // Create a Splash particle at the Player's position...
      //Instantiate(SplashObject, transform.position, transform.rotation);

        // Wait for 1 second before ending game...
        yield return new WaitForSeconds(1);
        gameManager.EndGame();
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Player collides with a car :O
        if (collision.gameObject.tag == "Vehicle")
        {
            canUpdate = false;
            gameObject.GetComponent<Rigidbody>().isKinematic = false;
            gameManager.EndGame();
        }
    }

    // END Collision Section ===================================================
   */




}