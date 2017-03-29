using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDisplay : MonoBehaviour {
    public Text textBlue;
    public Text textRed;

    private PlayerManager player;

    private void Awake()
    {
        player = GetComponent<PlayerManager>();
    }

    public void UpdateDisplay()
    {
        textBlue.text = "" + player.GetBlueTotal();
        textRed.text = "No" + player.GetRedTotal();
    }

}
