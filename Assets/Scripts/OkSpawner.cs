using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OkSpawner : MonoBehaviour
{
    [SerializeField] GameObject _ok;
    [SerializeField] AudioSource _arrowsound;
     public float time;
    private void FixedUpdate()
    {
        time += Time.deltaTime;
    }
     void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            TuzakSpawnStart();
        }
    }

    void TuzakSpawnStart()
    {
       if(time>=0.5f)
        {
         _arrowsound.Play(0);
             if (PlayerController._atisyonu.flipX == true)
                 {
           
                      Instantiate(_ok, transform.position, Quaternion.Euler(0, -17.04f, 196));
                  }
             else
                  {
                      Instantiate(_ok, transform.position,_ok.transform.rotation);
                  }
            time = 0;
        }
      
    }
   
  
}
