using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pauser : MonoBehaviour {

    public void Pause()
    {
        Debug.Log("pause");
        Time.timeScale = 0;
    }
}
