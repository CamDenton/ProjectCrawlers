using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordCollectible : MonoBehaviour {
    public string weaponName = "Dull Longsword";
    public int attackModifier = 10;
    public InventoryScript inventoryAdd;
    public ItemScript item;
   
	// Use this for initialization
	void Start () {
        inventoryAdd = new InventoryScript();
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player" && other.gameObject.GetComponent<KnightClass>())
        {
            inventoryAdd.Additem(item);
            other.gameObject.BroadcastMessage("ChangeAttack", attackModifier);

            Destroy(gameObject);

        }

    }
}
