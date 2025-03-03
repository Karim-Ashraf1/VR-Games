using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandAnimationScript : MonoBehaviour
{
    [SerializeField] InputActionProperty triggerbutton;
    [SerializeField] InputActionProperty gripbutton;

    [SerializeField] Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float triggerbuttonvalue = triggerbutton.action.ReadValue<float>();
        animator.SetFloat("Trigger", triggerbuttonvalue);

        float gripbuttonvalue = gripbutton.action.ReadValue<float>();
        animator.SetFloat("Grip", gripbuttonvalue);
    }
}
