using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodspawner : MonoBehaviour
{
    [SerializeField] GameObject[] food;
    private float Timer;

    // Start is called before the first frame update
    void Start()
    {
        Timer = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;
        if (Timer < 0)
        {
            int random = Random.Range(0,food.Length);
            GameObject random_food = food[random];

            Instantiate(random_food,transform.position, random_food.transform.rotation);
            Timer = 1f;
        }
    }
}
