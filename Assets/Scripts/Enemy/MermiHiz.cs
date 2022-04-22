using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MermiHiz : MonoBehaviour
{
     Rigidbody2D _rigid2;
    [SerializeField] float _speed;

    private void Awake()
    {
        _rigid2 = GetComponent<Rigidbody2D>();

    }
    private void Start()
    {
        Mermimove();
    }
    private void FixedUpdate()
    {

    }
    void Mermimove()
    {

        if (EnemyController._mermiyonu.flipX == true )
        {
            _rigid2.velocity = Vector2.left * _speed;
        }
        else
            _rigid2.velocity = Vector2.right * _speed;

    }
}
