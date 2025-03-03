using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation_script : MonoBehaviour
{
    [SerializeField] private Animator animatoor;
    // Start is called before the first frame update
    void Start()
    {
        animatoor = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("player"))
        {
            animatoor.SetBool("near to player", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("player"))
        {
            animatoor.SetBool("near to player", false);
        }
    }
}
