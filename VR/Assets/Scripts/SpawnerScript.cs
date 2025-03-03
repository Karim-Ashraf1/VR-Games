using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    [SerializeField] GameObject Enemy;
    private float Timer;
    private Vector3 enemyposition;
    [SerializeField] private Transform EnemyOffset;

    // Start is called before the first frame update
    void Start()
    {
        Timer = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;
        if (Timer<0)
        {
            enemyposition = new Vector3(Random.Range(-31f, -25f), Random.Range(-1f, -1f), Random.Range(10f, -2f));
            Instantiate(Enemy, enemyposition, EnemyOffset.rotation);
            Timer = 4f;
        }
    }
}
