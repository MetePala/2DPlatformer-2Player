using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ButonController : MonoBehaviour
{
    [SerializeField] GameObject _pause;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
       
    }
    private void FixedUpdate()
    {

    }

    public void LevelRestart()
    {
        Time.timeScale = 1;
        if (KapiAnimasyon._level==1)
        SceneManager.LoadScene("Level1");
       else if (KapiAnimasyon._level == 2)
            SceneManager.LoadScene("Level2");

    }

    public void DevamEt()
    {
        Time.timeScale = 1;
        _pause.SetActive(false);
    }

    public void Ayarlar()
    {
        SceneManager.LoadScene("Ayarlar");
    }

    public void Cikis()
    {
        Application.Quit();
    }

    public void AnaMenu()
    {
        SceneManager.LoadScene("Play");
    }
    public void OyunaKaldiginYerdenDevam()
    {
        Time.timeScale = 1;
        if (KapiAnimasyon._level == 1)
            SceneManager.LoadScene("Level1");
        else if (KapiAnimasyon._level == 2)
            SceneManager.LoadScene("Level2");
    }
    public void YeniOyun()
    {
        AltinTopla._toplamaltin = 0;
        PlayerHasarAlma.PlayerCan = 5;
        KapiAnimasyon._level = 1;
        Time.timeScale=1;
        SceneManager.LoadScene("Level1");

    }
    public void YuksekSkor()
    {
        SceneManager.LoadScene("HighScore");
    }
}
