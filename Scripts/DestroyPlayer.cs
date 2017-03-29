using UnityEngine;
using System.Collections;

public class DestroyPlayer : MonoBehaviour
{
   
    void OnTriggerEnter (Collider hit)
    {
        if (hit.CompareTag("Player"))
        {
            PlayerManager playerManager = hit.gameObject.GetComponent<PlayerManager>();
            if (!playerManager.isInvincible)
            {
                Destroy(hit.gameObject);
            }
        }
    }
}