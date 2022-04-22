using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZipzipCompanent : MonoBehaviour
{
    [SerializeField] Rigidbody2D _rigid2;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player1Body"))
        {
            if (_rigid2.CompareTag("Player1Body"))
                _rigid2.AddForce(Vector2.up * 400);
        }
        else if(collision.gameObject.CompareTag("Player2Body"))
        {
            if(_rigid2.CompareTag("Player2Body"))
            _rigid2.AddForce(Vector2.up * 400);
        }

    }
}
