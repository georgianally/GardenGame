using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VisitorSpawnerScript : MonoBehaviour
{

    public GameObject visitor;
    //float randX;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;
    Vector3 originalPos;

    public Text money;
    //Biodome biodome;

    // Start is called before the first frame update
    void Start()
    {
        //biodome = new Biodome();
        originalPos = new Vector3(visitor.transform.position.x, visitor.transform.position.y, visitor.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            //spawnRate = spawnRate - GameController.SharedInstance.biodome.rating;
            nextSpawn = Time.time + spawnRate;
            //randX = Random.Range(-1f, 1f);
            whereToSpawn = new Vector2(-0.92f, -5.43f);
            visitor = ObjectPooler.SharedInstance.GetPooledObject();
            if(visitor != null)
            {
                visitor.transform.position = originalPos;
                //visitor.transform.rotation = Quaternion.identity;
                //visitor.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, true);
                //visitor.GetComponent<SpriteRenderer>().sortingOrder = 1;
                visitor.SetActive(true);
                GameController.SharedInstance.VisitorEnter();
                //biodome.money = biodome.money + biodome.ticketPrice;

                //money.text = "Money: " + biodome.money.ToString();
            }
        }
    }
}
