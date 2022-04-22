using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalCompanent : MonoBehaviour
{


    private void Update()
    {
        transform.Rotate(new Vector3(0, 0, 3000) * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
       if(gameObject.CompareTag("portal1"))
        {
            if (col.gameObject.CompareTag("Player1Body"))
            {
                col.gameObject.transform.position = new Vector3(2.1f, 39.1f, 0);
            }
            if (col.gameObject.CompareTag("Player2Body"))
            {
                col.gameObject.transform.position = new Vector3(2.1f, 39.1f, 0);
            }
        }
        if (gameObject.CompareTag("portal2"))
        {
            if (col.gameObject.CompareTag("Player1Body"))
            {
                col.gameObject.transform.position = new Vector3(-3.1f, 39.1f, 0);
            }
            if (col.gameObject.CompareTag("Player2Body"))
            {
                col.gameObject.transform.position = new Vector3(-3.1f, 39.1f, 0);
            }
        }

    }
}
