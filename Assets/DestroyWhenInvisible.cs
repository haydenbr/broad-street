using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWhenInvisible : MonoBehaviour {

    private void OnBecameInvisible()
    {
        Debug.Log("Became Invisible");
      gameObject.SetActive(false);
        Destroy(this.gameObject);
    }
}
