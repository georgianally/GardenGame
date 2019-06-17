using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisitorSpawnerScript : MonoBehaviour
{

    public GameObject visitor;
    float randX;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(-1f, 1f);
            whereToSpawn = new Vector2(randX, transform.position.y);
            Instantiate(visitor, whereToSpawn, Quaternion.identity);
        }
    }

    void OnBecameInvisible()
    {
        Destroy(visitor);
    }
}
