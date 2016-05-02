using UnityEngine;
using System.Collections;

public class deathscript : MonoBehaviour {

    public GameObject meuf;
    void OnTriggerEnter(Collider hit)
    {
        if (hit.gameObject.tag == "Player")
        {
            Debug.Log("contact");
            Application.LoadLevel("Menu");
        }
    }

}
