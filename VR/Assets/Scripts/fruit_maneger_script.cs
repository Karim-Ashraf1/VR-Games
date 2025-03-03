using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruit_maneger_script : MonoBehaviour
{
    [SerializeField] float speed;

    void Update()
    {
        transform.position += Vector3.forward * speed * Time.deltaTime;
    }
}
