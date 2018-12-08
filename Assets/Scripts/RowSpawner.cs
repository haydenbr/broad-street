using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RowSpawner : MonoBehaviour {
    private List<GameObject> listRows = new List<GameObject>();
    public GameObject[] rows;
    public float tileSize = 10;
    public int numRows = 15;
   
    Vector3 spawnPosition = new Vector3(0f, 0f, 0f);

	// Use this for initialization
	void Start () {
       
        spawnPosition = transform.position;

        for (int i = 0; i <= numRows;i++){
            SpawnStrip();
        }
   	}
	
    // This function can be called from outside of this script...
    public void SpawnStrip(){
      
        listRows.Add(
            Instantiate(rows[Random.Range(0, rows.Length)], spawnPosition, transform.rotation)
        );
        spawnPosition.z += tileSize;

    }

    public void DeleteFirstStrip(){
        foreach (Transform child in listRows[0].transform)
        {
            Destroy(child.gameObject);
        }

        Destroy(listRows[0].gameObject);
        listRows.RemoveAt(0);

    }

  
}
