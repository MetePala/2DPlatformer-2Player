using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] Animator _enemyAnimation;
    [SerializeField] Rigidbody2D _enemyRigid2D;
    [SerializeField]  SpriteRenderer _enemyRenrerer;
    public static SpriteRenderer _mermiyonu;
    [SerializeField] float _enemySpeed;
    bool a = false, b;
    bool _dusmanyok = true;
    [SerializeField]float _currentTime;
    [SerializeField] GameObject _mermi;
    [SerializeField] GameObject _mermiSpawner;
    bool _mermii = false;
    float _mermiatis;
    private void Awake()
    {
        EnemyHasarAlma._enemyDead = false;
        _enemyRigid2D=GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        _currentTime += Time.deltaTime;
      
        if (a && EnemyHasarAlma._enemyDead == false)
        {
            EnemyKosSag();
        }
        else if(a==false && _dusmanyok==false)
            EnemyDur();
        if (b && EnemyHasarAlma._enemyDead == false)
        {
            EnemyKosSol();
        }
        if (EnemyHasarAlma._enemyDead == true)
        {
            EnemyDur();
        }
        if (_dusmanyok && EnemyHasarAlma._enemyDead == false)
        {

            if (_currentTime <=4)
            {
               
                _enemyRenrerer.flipX = false;
                _enemyRigid2D.velocity = Vector2.right * Time.deltaTime * _enemySpeed;
            }
            else
            {
                if (_currentTime >= 8)
                    _currentTime = 0;

               
                _enemyRenrerer.flipX = true;
                _enemyRigid2D.velocity = Vector2.left * Time.deltaTime * _enemySpeed;
            }
        }
        else
        {
          
        }
    }
    private void Update()
    {
        if(_mermii==true && EnemyHasarAlma._enemyDead == false)
        {
            MermiGonder();
        }
    }
    
    void MermiGonder()
    {
        _mermiatis += Time.deltaTime;
        if (_mermiatis >= 1)
        {
            _mermiyonu = _enemyRenrerer;
            Instantiate(_mermi, transform.position, _mermi.transform.rotation);
            _mermii = false;
            _mermiatis = 0;
        }
        
    }
    private void OnTriggerStay2D(Collider2D col)
    {
      
        if (col.gameObject.CompareTag("Player1Body") || col.gameObject.CompareTag("Player2Body"))
        {

            float _mesafe = gameObject.transform.position.x - col.gameObject.transform.position.x;
            if (_mesafe<=0 && EnemyHasarAlma._enemyDead == false)
            {
                a = true;
                _enemyRenrerer.flipX = false;
            }
                
            else if(_mesafe >= 0 && EnemyHasarAlma._enemyDead == false)
            {
                b = true;
                _enemyRenrerer.flipX = true;
            }
               

            _dusmanyok = false;
           
            _enemyAnimation.SetBool("__isRun", true);
            if((float)Mathf.Abs((col.transform.position.x - gameObject.transform.position.x))<=3)
            {
                a = false;
                b = false;
                _enemyAnimation.SetBool("__isRun", false);
                _enemyAnimation.SetBool("__isAttack", true);
                _mermii = true;

            }
            else if ((float)Mathf.Abs((col.transform.position.x - gameObject.transform.position.x)) >= 3)
            {
                _enemyAnimation.SetBool("__isAttack", false);
                _enemyAnimation.SetBool("__isRun", true);
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        a = false;
        b = false;
        _dusmanyok = true;
        _enemyAnimation.SetBool("__isRun", false);
        _enemyAnimation.SetBool("__isAttack", false);
    }
    void EnemyKosSag()
    {
        _enemyRigid2D.velocity = Vector2.right * Time.deltaTime * (_enemySpeed*2);
    }
    void EnemyKosSol()
    {
        _enemyRigid2D.velocity = Vector2.left * Time.deltaTime * (_enemySpeed * 2);
    }
    void EnemyDur()
    {
        _enemyRigid2D.velocity = Vector2.right * Time.deltaTime * 0;
    }
}
