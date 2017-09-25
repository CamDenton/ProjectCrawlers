using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagePlayers : MonoBehaviour {

    public bool singleSelected = false;
    public bool twoSelected = false;
    // Use this for initialization
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
