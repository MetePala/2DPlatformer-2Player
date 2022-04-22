using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI4 : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void YeniOyun()
    {
        SceneManager.LoadScene(4);
    }

    public void DevamEt()
    {
        SceneManager.LoadScene(2);
    }

    public void Ayarlar()
    {
        SceneManager.LoadScene(3);
    }

    public void Cikis()
    {
        Application.Quit();
    }

    public void AnaMenu()
    {
        SceneManager.LoadScene(0); 
    }

}
