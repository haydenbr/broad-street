using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleSpawn : MonoBehaviour {
    public GameObject[] vehicle;

	// Use this for initialization
	void Start () {
        Instantiate(vehicle[Random.Range(0, vehicle.Length)], transform.position, transform.rotation, this.transform);
		
	}
	

}
