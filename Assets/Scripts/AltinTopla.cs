using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AltinTopla : MonoBehaviour
{
    [SerializeField] Text _scoreText;
    public static int _toplamaltin;
    private void Awake()
    {
        _toplamaltin= PlayerPrefs.GetInt("toplamaltin");
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag=="Altin")
        {
            Destroy(col.gameObject);
            _toplamaltin = int.Parse(_scoreText.text);
            _toplamaltin += 1;
            _scoreText.text = _toplamaltin.ToString();
        }
        if (col.gameObject.tag == "Altinx5")
        {
            Destroy(col.gameObject);
            _toplamaltin = int.Parse(_scoreText.text);
            _toplamaltin += 8;
            _scoreText.text = _toplamaltin.ToString();
        }
    }
}
