using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCompanent : MonoBehaviour
{
    [SerializeField] GameObject _key;
   public static bool _keyAktifMi = false;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.CompareTag("Player1Body") || col.gameObject.CompareTag("Player2Body"))
        {
            _keyAktifMi = true;
            _key.SetActive(true);
            Destroy(gameObject);

        }
    }
}
