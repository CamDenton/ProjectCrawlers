using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordCollectible : MonoBehaviour {
    public string weaponName = "Dull Longsword";
    public int attackModifier = 10;
    public WeaponSlot weapon;
    public ItemScript item;
   
	// Use this for initialization
	void Start () {
        weapon = GameObject.Find("Weapon Slot").GetComponent<WeaponSlot>();
        
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player" && other.gameObject.GetComponent<KnightClass>())
        {
            weapon.addWeapon(item);
            other.gameObject.BroadcastMessage("ChangeAttack", attackModifier);

            Destroy(gameObject);

        }

    }
}
