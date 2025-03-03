using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_colliderscript : MonoBehaviour
{
    private float enemy_health = 30;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("player"))
        {
            enemy_health -= 10;
            if (enemy_health == 0)
            {
                Debug.Log("enemy destroed");
                Destroy(other.gameObject);
            }
        }
    }
}
