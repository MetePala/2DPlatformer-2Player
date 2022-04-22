using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MerdivenTrigger : MonoBehaviour
{
    [SerializeField] Rigidbody2D _Player1rigid2, _Player2rigid2;
    float a;
  
    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player1Body")
        {
            a = PlayerController.a;
            PlayerController._player1jumphiz = 0f;
            col.gameObject.transform.position += new Vector3(0, Input.GetAxis("Vertical") * 3 * Time.deltaTime);
            _Player1rigid2.gravityScale = 0;
            

        }
        else if (col.gameObject.tag == "Player2Body")
        {
            a = PlayerController.a;
            PlayerController._player2jumphiz = 0f;
            col.gameObject.transform.position += new Vector3(0, Input.GetAxis("Vertical2") * 3 * Time.deltaTime);
            _Player2rigid2.gravityScale = 0;
        }
        
        
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player1Body")
        {
            _Player1rigid2.gravityScale = 1;
            PlayerController._player1jumphiz = a;
        }
        if (col.gameObject.tag == "Player2Body")
        {
            _Player2rigid2.gravityScale = 1;
            PlayerController._player2jumphiz = a;
        }
       
      
    }

}
