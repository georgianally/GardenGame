using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryByBoundary : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Boundary")
        {
            if (gameObject.tag == "Visitor")
            {
                gameObject.SetActive(false);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
