using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StripSpawner : MonoBehaviour {
    public List<GameObject> listStrips = new List<GameObject>();
    public GameObject[] strips;
    public float tileSize = 10;
   
    Vector3 spawnPosition = new Vector3(0f, 0f, 0f);

	// Use this for initialization
	void Start () {
       
        spawnPosition = transform.position;

        for (int i = 0; i <= 15;i++){
            SpawnStrip();
        }
   	}
	
    // This function can be called from outside of this script...
    public void SpawnStrip(){
      

        listStrips.Add(Instantiate(strips[Random.Range(0, strips.Length)], spawnPosition, transform.rotation));
        spawnPosition.z += tileSize;

    }

    public void DeleteFirstStrip(){
        foreach (Transform child in listStrips[0].transform)
        {
            Destroy(child.gameObject);
           
        }
       

        Destroy(listStrips[0].gameObject);
        listStrips.RemoveAt(0);

    }

  
}
