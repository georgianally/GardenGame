using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VisitorSpawnerScript : MonoBehaviour
{

    public GameObject visitor;
    float randX;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;

    public Text money;
    //Biodome biodome;

    // Start is called before the first frame update
    void Start()
    {
        //biodome = new Biodome();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(-1f, 1f);
            whereToSpawn = new Vector2(randX, transform.position.y);
            visitor = ObjectPooler.SharedInstance.GetPooledObject();
            if(visitor != null)
            {
                visitor.transform.position = whereToSpawn;
                visitor.transform.rotation = Quaternion.identity;
                visitor.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, true);
                visitor.SetActive(true);
                GameController.SharedInstance.VisitorEnter();
                //biodome.money = biodome.money + biodome.ticketPrice;

                //money.text = "Money: " + biodome.money.ToString();
            }
        }
    }
}
