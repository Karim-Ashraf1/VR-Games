using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class RedLightSaberScript : MonoBehaviour
{
    public XRBaseController xRController;
    [SerializeField] AudioSource hitsound;
    [SerializeField] LogicScript logic;

    private void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("red"))
        {
            logic.addscore(1);

            Debug.Log("hit");

            hit_sound();

            xRController.SendHapticImpulse(.5f, .5f);

            Destroy(other.gameObject); // fruit
        }
    }

    public void hit_sound()
    {
        hitsound.Play();
    }

}
