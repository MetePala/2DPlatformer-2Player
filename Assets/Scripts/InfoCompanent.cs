using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoCompanent : MonoBehaviour
{
    [SerializeField] GameObject _infotext;
    private void OnTriggerStay2D(Collider2D col)
    {
        _infotext.SetActive(true);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        _infotext.SetActive(false);
    }
}
