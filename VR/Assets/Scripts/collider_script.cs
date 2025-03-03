using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collider_script : MonoBehaviour
{
    private float player_health =30 ;
    [SerializeField] AudioSource deathsound;
    [SerializeField] AudioSource hitsound;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("player_"))
        {
            Debug.Log("hit");
            hit_sound();
            player_health -= 10;
            if (player_health == 0)
            {
                Debug.Log("player destroed");
                death_sound();
                //Destroy(other.gameObject);
                SceneManager.LoadScene("Test_Map");
            }
        }
    }

    public void death_sound()
    {
        deathsound.Play();
    }
    public void hit_sound()
    {
        hitsound.Play();
    }

}
