using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyHasarAlma : MonoBehaviour
{
    [SerializeField] Slider _can;
    [SerializeField]Rigidbody2D _enemyRigid2D;
    Animator _anim;
    public static bool _enemyDead;
    bool _vurdu ;
    private void Awake()
    {
        _anim = GetComponent<Animator>();

    }
    private void Update()
    {
        if (_can.value <= 0)
        {
            //_enemyDead = true;
            Destroy(GetComponentInParent<Rigidbody2D>());
            Destroy(GetComponentInParent<EnemyController>());
          
            _anim.SetTrigger("__isDead");
            BoxCollider2D _bxcol = GetComponent<BoxCollider2D>();
            _bxcol.enabled = false;
            _can.enabled = false;
          //  Destroy(GetComponent<Rigidbody2D>());
          
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _vurdu = true;
        }
       
    }
  


    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "ok" || col.gameObject.tag == "kilic")
        {
            Destroy(col.gameObject);
            _can.value -= 40;
        }
       
    }
    private void OnTriggerStay2D(Collider2D col)
    {
       if(_vurdu)
        {
            if (col.gameObject.CompareTag("hasarver"))
            {
                _can.value -= 25;
                _vurdu = false;
            }
                
        }
           

    }

}
