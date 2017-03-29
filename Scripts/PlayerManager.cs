using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{

    private int blueTotal = 0;
    private int timeBetweenBlueSpawns = 10;
    public Text redNo;
    public Text redYes;
    private int timeBetweenRedSpawns = 10;

    public float invincibleTime = 10f;
    public bool isInvincible = false;

    public spawnBlock blockSpawner;
    public GameObject inventoryPanel;
    public GameObject[] inventoryIcons;
    private PlayerDisplay playerDisplay;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Blue"))
        {
            Destroy(other.gameObject);
            blockSpawner.SpawnOneBlockAfterDelay(timeBetweenBlueSpawns);
            blueTotal++;
            playerDisplay.UpdateDisplay();
            print("Blue Total Equals" + blueTotal);
        }
        if (other.CompareTag("Red"))
        {
            gameObject.tag = "Invincible";
            gameObject.layer = 13;
            Destroy(other.gameObject);
            blockSpawner.SpawnOneBlockAfterDelay(timeBetweenRedSpawns);
            playerDisplay.UpdateDisplay();

            SetInvincible();
        }
    }

    public void SetInvincible()
    {
        isInvincible = true;
        CancelInvoke("SetDamagable");
        Invoke("SetDamagable", invincibleTime);
        redNo.text = " ";
        redYes.text = "Yes";
    }

    void SetDamagable()
    {
        isInvincible = false;
        gameObject.tag = "Player";
        gameObject.layer = 12;
        redYes.text = "No";
    }

    public int GetBlueTotal()
    {
        return blueTotal;
    }
    
    public string GetRedTotal()
    {
        return redYes.text;
    }

    public void Start()
    {
        playerDisplay = GetComponent<PlayerDisplay>();
        playerDisplay.UpdateDisplay();
    }


}
