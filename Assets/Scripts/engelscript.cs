using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class engelscript : MonoBehaviour
{

    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Player1Body")
        {
            collision.collider.transform.SetParent(transform);
        }
        if (collision.gameObject.tag == "Player2Body")
        {
            collision.collider.transform.SetParent(transform);
        }

    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player1Body")
        {
            collision.collider.transform.SetParent(null);
        }
        if (collision.gameObject.tag == "Player2Body")
        {
            collision.collider.transform.SetParent(null);
        }
    }

    private void FixedUpdate()
    {
    }
  

}
