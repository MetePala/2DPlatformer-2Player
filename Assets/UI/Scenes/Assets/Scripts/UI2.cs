using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI2 : MonoBehaviour
{
    float sure2;
    //UI uı;
    [SerializeField] Text _text, _text2, _skorText;
    [SerializeField] GameObject _image;

    float toplamsure;
    private void Awake()
    {
        toplamsure = PlayerPrefs.GetFloat("sure");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ToplamSure();
    }

    void sureEkle()
    {
         

        _text.text = PlayerPrefs.GetString("sure");
    }

    void ToplamSure()
    {
        toplamsure +=Time.deltaTime;
        _text2.text = toplamsure.ToString("0.##");
        sure2 += Time.deltaTime;
        _text.text = sure2.ToString("0.##");
        
        PlayerPrefs.SetFloat("sure", toplamsure);

        

    }

    public void YuksekSkor()
    {
        _image.SetActive(true);
        _skorText.text = toplamsure.ToString();
    }

    public void Menu()
    {
        SceneManager.LoadScene(1);
    }

}
