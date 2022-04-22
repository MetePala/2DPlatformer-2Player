using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HighScore : MonoBehaviour
{
    [SerializeField] Text _score1, _score2;
    private void Awake()
    {
      
        _score1.text= PlayerPrefs.GetFloat("score1").ToString("0.##") + " Saniye";
        _score2.text = PlayerPrefs.GetFloat("score2").ToString("0.##") + " Saniye";
    }
}
