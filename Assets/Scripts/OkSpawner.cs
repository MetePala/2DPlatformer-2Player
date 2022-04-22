using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OkSpawner : MonoBehaviour
{
    [SerializeField] GameObject _ok;
    
    private void FixedUpdate()
    {
       
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

        if (PlayerController._atisyonu.flipX == true)
        {
            Instantiate(_ok, transform.position, Quaternion.Euler(0, -17.04f, 196));
        }
        else
        {
            Instantiate(_ok, transform.position,_ok.transform.rotation);
        }
    }
   
  
}
