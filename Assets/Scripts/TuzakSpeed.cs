using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuzakSpeed : MonoBehaviour
{
    Rigidbody2D _rigid2;
    [SerializeField] float _speed;
    private void Awake()
    {
        _rigid2 = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        Tuzakmove();
    }
    void Tuzakmove()
    {
        _rigid2.velocity = Vector2.down * Time.deltaTime * _speed;
    }
}
