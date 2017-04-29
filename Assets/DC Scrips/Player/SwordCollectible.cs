using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordCollectible : MonoBehaviour {
    public string weaponName = "Dull Longsword";
    public int attackModifier = 10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player" && other.gameObject.GetComponent<KnightClass>())
        {
            other.gameObject.BroadcastMessage("ChangeAttack", attackModifier);

            Destroy(gameObject);

        }

    }
}
