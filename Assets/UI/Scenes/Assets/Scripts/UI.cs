using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI : MonoBehaviour
{

    public static float sure;
    [SerializeField] Text _text, _text2;


    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.GetFloat("sure");
        
    }

    // Update is called once per frame
    void Update()
    {
        ToplamSure();
        Cikis();
    }

    public void Menu()
    {
        SceneManager.LoadScene(1);
    }

    public void DevamEt()
    {
        SceneManager.LoadScene(2);
    }

    public void AnaMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Ayarlar()
    {
        SceneManager.LoadScene(3);
    }

    public void Ayarlar2()
    {
        SceneManager.LoadScene(0);
    }


    public void YeniOyun()
    {
        SceneManager.LoadScene(4);
    }

    public void YeniOyunLevel2()
    {
        SceneManager.LoadScene(4);
    }

    public void Cikis()
    {
        Application.Quit();
    }

    void ToplamSure()
    {
        sure += Time.deltaTime;
        _text.text = sure.ToString("0.##");
        PlayerPrefs.SetFloat("sure", sure);
       
    }
         public void SureButton()
    {
        
        _text2.text = PlayerPrefs.GetFloat("sure").ToString("0.##");
       
    }

}
