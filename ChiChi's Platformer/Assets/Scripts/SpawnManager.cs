using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ball;
    void Start()
    {
        InvokeRepeating("SpawnRandomBall", 1.0f, Random.Range(3, 8));
    }

    // Update is called once per frame
    void SpawnRandomBall ()
    {
        Vector3 spawnPos = new Vector3(Random.Range(10, 7), 10, 0);
        Instantiate(ball, spawnPos, ball.transform.rotation);
    }
}
