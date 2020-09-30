using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereSpawner : MonoBehaviour
{
    public GameObject ball;
    public float spawnRate = 1f;
    float t = 0;
    public float randomness = .5f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;

        if (t > spawnRate)
        {
            Instantiate(ball,transform.position + new Vector3(0, Random.Range(-randomness, randomness), Random.Range(-randomness,randomness)), transform.rotation);
            t = 0f;
        }
    }
}
