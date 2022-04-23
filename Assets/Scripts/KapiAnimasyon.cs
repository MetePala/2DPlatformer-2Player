using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class KapiAnimasyon : MonoBehaviour
{
    [SerializeField]Animator _anim;
    [SerializeField] GameObject _player1, _player2;
    [SerializeField] GameObject winCanvas;
    [SerializeField] Text winScoreText;
    public static bool _kapi1Aktifmi, _kapi2Aktifmi;
    public static int _level=1;
    float _yuksekskor=999;
    float a;
    float timee;
    float _scoretut;

    private void Start()
    {
       if(PlayerPrefs.GetFloat("score1")<1)
        PlayerPrefs.SetFloat("score1", 999);

        if (PlayerPrefs.GetFloat("score2") < 1)
            PlayerPrefs.SetFloat("score2", 999);
      
    }

    private void OnTriggerStay2D(Collider2D col)
    {
       if(_level==1)
        {
            a = _player1.transform.position.x - _player2.transform.position.x;
            float mutlakDegera = (float)Mathf.Abs(a);
            if (col.gameObject.CompareTag("Player1Body") || col.gameObject.CompareTag("Player2Body") && KeyCompanent._keyAktifMi)
            {
                if (mutlakDegera <= 1)
                {
                    _anim.enabled = true;
                    timee += Time.deltaTime;
                    if (timee > 2)
                    {
                        _scoretut = TimerController._timer;
                        _yuksekskor = PlayerPrefs.GetFloat("score1");
                        PlayerPrefs.SetInt("toplamaltin", AltinTopla._toplamaltin);
                        if (_scoretut < _yuksekskor)
                        {
                            PlayerPrefs.SetFloat("score1", _scoretut);
                        }
                       
                        _level = 2;
                        SceneManager.LoadScene("Level2");
                    }

                }

            }

        }
       else if(_level==2 && KeyCompanent._keyAktifMi)
        {
            if(gameObject.CompareTag("door1"))
            {
                _kapi1Aktifmi = true;
            }
           else if(gameObject.CompareTag("door2"))
            {
                _kapi2Aktifmi = true;
            }
            if(_kapi1Aktifmi==true && _kapi2Aktifmi==true)
            {
                _anim.enabled = true;
                timee += Time.deltaTime;
                if (timee > 2)
                {
                    _scoretut = TimerController._timer;
                    _yuksekskor = PlayerPrefs.GetFloat("score2");
                    PlayerPrefs.SetInt("toplamaltin", AltinTopla._toplamaltin);
                    if (_scoretut < _yuksekskor)
                    {
                        PlayerPrefs.SetFloat("score2", _scoretut);
                    }
                    //  _level = 3;
                    Time.timeScale = 0;
                    winScoreText.text= PlayerPrefs.GetFloat("score2").ToString();
                    winCanvas.SetActive(true);
                    
                }

            }
        }
       
       
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        _kapi1Aktifmi = false;
        _kapi2Aktifmi = false;
    }


}
