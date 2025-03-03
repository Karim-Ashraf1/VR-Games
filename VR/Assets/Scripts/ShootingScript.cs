using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform bulletOffset;
    private Rigidbody bulletRB;
    [SerializeField] AudioSource shootsound;
    private bool hitenemy = true;
    private float timer;
    private float timertime=4f;

    private void Start()
    {
        timer = timertime;
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer == 0)
        {
            hitenemy = false;
            timer = timertime;
        }
        if (hitenemy == false && timer == 0)
        {
            Destroy(bullet);
        }
    }

    public void shoot()
    {
        GameObject bulletprefab = Instantiate(bullet, bulletOffset.position, bulletOffset.rotation);

        bulletRB = bulletprefab.GetComponent<Rigidbody>();
        bulletRB.AddForce(bulletOffset.forward * 100, ForceMode.Impulse);

        shoot_sound();
    }

    public void shoot_sound()
    {
        shootsound.Play();
    }
}
