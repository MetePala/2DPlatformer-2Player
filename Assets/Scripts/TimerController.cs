using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class TimerController : MonoBehaviour
{
    public static float _timer;
    [SerializeField] Text _timerText;
    float _dakika, _saniye;
    // Start is called before the first frame update
    void Start()
    {
        _timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        _timer += Time.deltaTime;

        if (_timer <= 59)
            _timerText.text = _timer.ToString("00:00");
        else if (_timer > 59)
        {

            _saniye = _timer % 60;

            if (_saniye > 59.8f)
                _dakika = _timer / 60;


            _timerText.text = _dakika.ToString("00") + _saniye.ToString(":00");
        }
       
    }
}
