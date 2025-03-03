using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawnerScript : MonoBehaviour
{
    [SerializeField] GameObject[] cubes;
    private float T;
    private Vector3 cubeposition;

    // Start is called before the first frame update
    void Start()
    {
        T = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        T -= Time.deltaTime;
        if (T<0)
        {
            int random = Random.Range(0, cubes.Length);
            GameObject random_cube = cubes[random];

            cubeposition = new Vector3(Random.Range(-40f, -40f), Random.Range(0f, 0f), Random.Range(9f, -1f));

            Instantiate(random_cube, cubeposition ,random_cube.transform.rotation);

            T = Random.Range(2,4);
        }
    }
}
