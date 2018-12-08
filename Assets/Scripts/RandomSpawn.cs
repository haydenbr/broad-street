using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    // List of vehicles we can add through the Inspector...
    public GameObject[] vehicle;

    // We can set minimum and maximum spawn time here...
    public float maxTime = 5;
    public float minTime = 2;

    public bool destroyAfterOne = false;

    // Current time...
    private float time;

    // Random time to spawn a new GameObject...
    private float spawnTime;

    void Start()
    {
        // Initialize timer...
        SetRandomTime();
        time = minTime;
    }

    // FixedUpdate is called once per frame.
    // Called every physics step.
    // FixedUpdate intervals are consistent (always take the same amount of time).
    void FixedUpdate()
    {
        
        // Time.deltaTime is the time it takes to complete a frame.
        // So, we increment our timer by the time of one frame.
        time += Time.deltaTime;

        // We spawn an object and reset the random timer...
        if (time >= spawnTime)
        {
            SpawnObject();
            SetRandomTime();
        }

    }

    // Spawns the object and resets the timer
    void SpawnObject()
    {
        time = 0;
        int i = Random.Range(0, vehicle.Length);

        GameObject obj = Instantiate(vehicle[i], transform.position, transform.rotation);
        obj.transform.SetParent(this.transform.parent);

        if (destroyAfterOne==true){
            Destroy(this.gameObject);
        }
     

    }

    // Sets the random time between minTime and maxTime
    void SetRandomTime()
    {
        spawnTime = Random.Range(minTime, maxTime);
    }

}
