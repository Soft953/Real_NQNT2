using UnityEngine;
using System.Collections;

public class TradeScript : MonoBehaviour {

    public GameObject storage;
    private bool showGUI = false;
    private PlayerControl playercontrol;
	// Use this for initialization
	void Start ()
    {
        playercontrol = GameObject.Find("Health").GetComponent<PlayerControl>();
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider hit)
    {
        if (hit.gameObject.tag == "Player")
        {
            showGUI = true;
        }
    }
    void OnTriggerExit(Collider hit)
    {
        if (hit.gameObject.tag == "Player")
        {
            showGUI = false;
        }
    }
    void OnGUI()
    {
        if (showGUI)
        {
            GUI.BeginGroup(new Rect(Screen.width / 2 - 165, Screen.height / 2 - 75, 330, 150));
            GUI.Box(new Rect(0, 0, 330, 150), "SHOP");
            GUI.Label(new Rect(10, 20, 320, 300), "Hello i'm a merchant i sell a lot of differents things !");
            if (GUI.Button(new Rect(5, 60, 170, 30), "Spell 1 - Fire (50 gold)"))
            {
                storage.SetActive(true);
                if (PlayerControl.money >= 50)
                {
                    PlayerControl.money -= 50;
                }
            }
        }
    }
}
