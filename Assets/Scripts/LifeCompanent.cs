using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeCompanent : MonoBehaviour
{
    [SerializeField] Image Can1, Can2, Can3, Can4, Can5;
    [SerializeField] GameObject _gameovercanvas;
    [SerializeField] GameObject _pause;
    void Start()
    {
        _gameovercanvas.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            _pause.SetActive(true);
        }
    }
    void FixedUpdate()
    {

        CanAzalt();
    }
    void CanAzalt()
    {
        if (PlayerHasarAlma.PlayerCan == 4)
        {
            Destroy(Can5);

        }
        else if (PlayerHasarAlma.PlayerCan == 3)
        {
            Destroy(Can4);

        }
        else if (PlayerHasarAlma.PlayerCan == 2)
        {
            Destroy(Can3);

        }
        else if (PlayerHasarAlma.PlayerCan == 1)
        {
            Destroy(Can2);

        }
        else if (PlayerHasarAlma.PlayerCan == 0)
        {
            Destroy(Can1);
            Time.timeScale = 0;
            _gameovercanvas.SetActive(true);
           
        }
    }


}
