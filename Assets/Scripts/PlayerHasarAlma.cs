using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerHasarAlma : MonoBehaviour
{
    [SerializeField] Slider _playerCan,_otherPlayer;
    [SerializeField] GameObject _player1,_player2;
    public static int PlayerCan = 5;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("arrow"))
        {
            _playerCan.value -= 35;
            Destroy(col.gameObject);
        }
        else if (col.gameObject.CompareTag("mermi"))
        {
            _playerCan.value -= 30;
            Destroy(col.gameObject);
        }
      
    }
    private void OnTriggerStay2D(Collider2D col)
    {
         if (col.gameObject.CompareTag("tuzak"))
          {
            _playerCan.value -= 3;
         }
    }
    private void FixedUpdate()
    {
        if(_playerCan.value<=0)
        {
            PlayerCan -= 1;
            _playerCan.value = _playerCan.maxValue;
            _otherPlayer.value = _otherPlayer.maxValue;
            if (KapiAnimasyon._level==1)
            {
                _player1.transform.position = new Vector3(-15.5f, 2.1f);
                _player2.transform.position = new Vector3(-15.5f, -8f);
            }
            else if (KapiAnimasyon._level == 2 )
            {
                _player1.transform.position = new Vector3(-15.5f, -7f);
                _player2.transform.position = new Vector3(15.5f, -7.1f);
            }

        }
    }
}
