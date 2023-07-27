using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate;
    private float timer = 0;
    public float highOffSet;
    // Start is called before the first frame update
    void Start()
    {
        spawnPipes();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnPipes();
            timer = 0;
        }
    }

    void spawnPipes()
    {
        float lowesPoint = transform.position.y - highOffSet;
        float highestPoint = transform.position.y + highOffSet;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowesPoint, highestPoint), 0), transform.rotation);
    }
}
