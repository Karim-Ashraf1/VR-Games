using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyScript : MonoBehaviour
{
    [SerializeField] AudioSource diesound;
    [SerializeField] Transform target;
    [SerializeField] float speed;
    [SerializeField] private Animator animatoor;

    void Update()
    {
        if (!animatoor.GetBool("enemy die"))
        {
            if (target != null)
            {
                Vector3 direction = target.position - transform.position;
                transform.position += direction.normalized * speed * Time.deltaTime;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            animatoor.SetBool("enemy die", true);
            Destroy(collision.gameObject); // bullet
            die_sound();
            //Destroy(gameObject);
        }

    }
    public void die_sound()
    {
        diesound.Play();
    }
}
