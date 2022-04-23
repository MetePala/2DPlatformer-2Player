using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float _hSpeed, _vSpeed, _jSpeed;
    public static float _player1jumphiz, _player2jumphiz, a;
    [SerializeField] bool _isJumpPlayer1, _isJumpPlayer2;
    [SerializeField] GameObject _playerbody;
    public SpriteRenderer _renderer;
    public SpriteRenderer _renderer2;
    public static SpriteRenderer _atisyonu;
    [SerializeField] Animator _player1walk, _player2walk;
    Rigidbody2D _rigidbody2D;
    public bool IsJumpAction => _rigidbody2D.velocity != Vector2.zero;
    float _attacktime1,_attacktime2 = 0;
    bool _attack1,_attack2 = false;
    [SerializeField] AudioSource _swordsound;
    void Awake()
    {
        _rigidbody2D = GetComponentInChildren<Rigidbody2D>();
        _renderer = GetComponentInChildren<SpriteRenderer>();
        _renderer2 = GetComponentInChildren<SpriteRenderer>();
    }

    void Start()
    {
        _player1jumphiz = _jSpeed;
        _player2jumphiz = _jSpeed;
        a = _jSpeed;
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {

            _isJumpPlayer1 = true;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            _isJumpPlayer2 = true;
        }

    }
    private void FixedUpdate()
    {
        PlayerHareket();
        

        float _horiziontalvalue1 = Mathf.Abs(Input.GetAxis("Horizontal"));
        _player1walk.SetFloat("__isWalk", _horiziontalvalue1);
        float _horiziontalvalue2 = Mathf.Abs(Input.GetAxis("Horizontal2"));
        _player2walk.SetFloat("__isWalk", _horiziontalvalue2);
        if (_attack1==true)
        {
            _attacktime1 += Time.deltaTime;
            if (_attacktime1 >=0.5f)
            {
                _player1walk.SetBool("__isAttack", false);
                _attack1 = false;
            }
        }
        if (_attack2 == true)
        {
            _attacktime2 += Time.deltaTime;
          
            if (_attacktime2 >= 0.5f)
            {
                _player2walk.SetBool("__isAttack", false);
                _attack2 = false;
            }

        }

    }
  
    void PlayerHareket()
    {
        if (gameObject.tag == "Player1")
        {

            _playerbody.transform.position += new Vector3( Input.GetAxis("Horizontal") * Time.deltaTime * _hSpeed, 0);

            if (_isJumpPlayer1 && !IsJumpAction)
            {
                _player1walk.SetBool("__isAttack", false);
                _player1walk.SetBool("__isJump", true);
                _rigidbody2D.AddForce(Vector2.up * _player1jumphiz);
            }
            else if(!IsJumpAction)
                _player1walk.SetBool("__isJump", false);

            if (Input.GetAxis("Horizontal") < 0 )
            {
               
                _renderer2.flipX = true;
               
            }
            else if (Input.GetAxis("Horizontal") > 0)
            {
               
                _renderer2.flipX = false;
               
            }
            if (Input.GetKey(KeyCode.Space))
            {
                if(_attack1==false)
                {
                    _swordsound.Play(0);
                    _player1walk.SetBool("__isJump", false);
                    _attack1 = true;
                    _attacktime1 = 0;
                    _player1walk.SetBool("__isAttack", true);
                }
                else
                {

                }
            }
           
        }
       
        if (gameObject.tag == "Player2")
        {
          
            _playerbody.transform.position += new Vector3(Input.GetAxis("Horizontal2") * Time.deltaTime * _hSpeed, 0);


            if (_isJumpPlayer2 && !IsJumpAction)
            {
                _player2walk.SetBool("__isAttack", false);
                _player2walk.SetBool("__isJump", true);
                _rigidbody2D.AddForce(Vector2.up * _player2jumphiz);
            }
            else if (!IsJumpAction)
                _player2walk.SetBool("__isJump", false);
            if (Input.GetAxisRaw("Horizontal2") > 0)
            {
                _renderer.flipX = false;
                _atisyonu = _renderer;
            }
            else if (Input.GetAxisRaw("Horizontal2") < 0)
            {
                _renderer.flipX = true;
                _atisyonu = _renderer;
            }
            if (Input.GetKey(KeyCode.Alpha0))
            {
                if (_attack2 == false)
                {
                   
                    _player2walk.SetBool("__isJump", false);
                    _attack2 = true;
                    _attacktime2 = 0;
                    _player2walk.SetBool("__isAttack", true);
                }
                else
                {

                }
            }

        }
        _jSpeed = _player1jumphiz;
        _isJumpPlayer2 = false;
        _isJumpPlayer1 = false;
        

        
    }
    

}
