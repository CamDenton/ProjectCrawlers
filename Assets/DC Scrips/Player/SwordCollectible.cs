using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordCollectible : MonoBehaviour {
    public string weaponName;
    public int attackModifier;
    public ItemScript item;
   
	// Use this for initialization
	void Start () {

        attackModifier = item.attack;
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            PlayerStats otherStats = other.GetComponent<PlayerStats>();
            if (otherStats.playerClassType.ToString() == "Warrior (Classes)")
            {
                other.gameObject.GetComponentInChildren<WeaponSlot>().item = item;
                other.gameObject.GetComponentInChildren<WeaponSlot>().itemImage.sprite = item.spriteImage;
                other.gameObject.BroadcastMessage("ChangeAttack", attackModifier, SendMessageOptions.DontRequireReceiver);
                Destroy(gameObject);
            }

            else
            {

            }

        }

    }
}
