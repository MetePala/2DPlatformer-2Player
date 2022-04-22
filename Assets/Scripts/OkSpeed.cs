using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OkSpeed : MonoBehaviour
{
    Rigidbody2D _rigid2;
    [SerializeField] float _speed;
   
    private void Awake()
    {
        _rigid2 = GetComponent<Rigidbody2D>();
       
    }
    private void Start()
    {
        Okmove();
    }
    private void FixedUpdate()
    {
       
    }
    void Okmove()
    {
        
            if (PlayerController._atisyonu.flipX == false)
        {
            _rigid2.velocity = Vector2.right * _speed;
        }
      else
            _rigid2.velocity = Vector2.left * _speed;

    }
}