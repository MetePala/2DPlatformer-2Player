using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeTimeController : MonoBehaviour
{

    [SerializeField] float _LifeTime;
    float _currentTime;
    private void FixedUpdate()
    {
        _currentTime += Time.deltaTime;

        if (_currentTime > _LifeTime)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("platform") || col.gameObject.CompareTag("box"))
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("box"))
        {
            Destroy(gameObject);
        }
    }
}
