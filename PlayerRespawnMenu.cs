using UnityEngine;
using System.Collections;

namespace CompleteProject
{
public class PlayerRespawnMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
    void OnGUI()
    {
        if(Player.PlayerisDead == true) {
                print("player is dead");
            if (GUI.Button(new Rect(Screen.width*.5f-50f, 200 - 20, 100, 40), "Respawn"))
            {
                print("respawn");
            }
        }
     }
}

}