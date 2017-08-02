using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WinCondition : MonoBehaviour {

    public bool isComplete = false;
    public WCSpawns destroyedAll;

    void Start()
    {
            
    }

    void Update()
    {
        if (destroyedAll.isComplete == true || destroyedAll == null)
        {
            isComplete = true;
            Debug.Log(isComplete);
        }
    }

}
