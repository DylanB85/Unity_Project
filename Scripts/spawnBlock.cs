using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnBlock : MonoBehaviour {

    public GameObject freeze_Block;
    public GameObject shield_Block;
    public Transform canvas;
    int spawnNum = 1;

    void SpawnFreeze()
    {
        for(int i=0; i<spawnNum; i++)
        {
            SpawnFreezeBlock();
        }
    }

    void SpawnShield()
    {
        for (int i = 0; i < spawnNum; i++)
        {
            SpawnShieldBlock();
        }
    }

    // Use this for initialization
    void Start () {
        SpawnFreeze();
        SpawnShield();
		
	}

    public void SpawnOneBlockAfterDelay(int delaySeconds)
    {
        Invoke("SpawnFreezeBlock", delaySeconds);
        Invoke("SpawnShieldBlock", delaySeconds);
    }

    public void SpawnFreezeBlock()
    {
        Vector3 blockPos = new Vector3(canvas.position.x + Random.Range(-5.0f, 7.5f),
                                       canvas.position.y + Random.Range(2.6f, 2.6f),
                                        canvas.position.z + Random.Range(6.5f, -6.6f));
        Instantiate(freeze_Block, blockPos, Quaternion.identity);
    }

    public void SpawnShieldBlock()
    {
        Vector3 blockPos = new Vector3(canvas.position.x + Random.Range(-5.0f, 7.5f),
                               canvas.position.y + Random.Range(2.6f, 2.6f),
                                canvas.position.z + Random.Range(6.5f, -6.6f));
        Instantiate(shield_Block, blockPos, Quaternion.identity);
    }

}
