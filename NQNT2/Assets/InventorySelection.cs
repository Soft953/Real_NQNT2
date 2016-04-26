using UnityEngine;
using System.Collections;

public class InventorySelection : MonoBehaviour {

    public GameObject inventory;
    public GameObject character;
    bool inventoryOpen;
    bool characterOpen;
    // Use this for initialization
    void Start ()
    {
        inventoryOpen = false;
        characterOpen = false;   
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown("i"))
        {
            if (inventoryOpen)
            {
                inventory.SetActive(false);
                inventoryOpen = false;
                /*if ()
                {

                }*/
            }
            else
            { 
                inventory.SetActive(true);
                inventoryOpen = true;
            }

        }
        if (Input.GetKeyDown("c"))
        {
            if (characterOpen)
            {
                character.SetActive(false);
                characterOpen = false;
            }
            else
            {
                character.SetActive(true);
                characterOpen = true;
            }
        }
    }
}
