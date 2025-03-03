using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(XRRayInteractor))]
public class ControllerHandler : MonoBehaviour
{

    private void Start()
    {
        var interactor = GetComponent<XRRayInteractor>();
        
        interactor.selectEntered.AddListener(a =>
        {
            Debug.Log("entered");

            if (a.interactableObject.transform.GetComponent<Sword>())
                a.interactableObject.transform.GetComponent<Sword>().xRController = GetComponent<XRBaseController>();
             });
    }

}
