using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yataytriggerscript : MonoBehaviour
{
    [SerializeField]Rigidbody2D _player1Rigid, _player2Rigid;

    private void Awake()
    {
      
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player2Body")
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                _player2Rigid.AddForce(Vector2.up * 280);
            }
        }
        if (collision.gameObject.tag == "Player1Body")
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                _player1Rigid.AddForce(Vector2.up * 280);
            }
        }
    }
}
