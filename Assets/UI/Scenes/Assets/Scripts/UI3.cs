using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI3 : MonoBehaviour
{
    float sure2;
    //UI uı;
    [SerializeField] Text _skorText;
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
        
    }

    


    public void YuksekSkor()
    {
        _image.SetActive(true);
        _skorText.text = toplamsure.ToString("0.##");
    }

    

}
