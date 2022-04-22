using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformHareket : MonoBehaviour
{
    [SerializeField] GameObject _dugme;
    Animator m_Animator;
    [SerializeField]Animator _platformAnim;
    [SerializeField] Animator _box1Anim, _box2Anim;
    int a=0,b=0;
    private void Awake()
    {
        m_Animator = _dugme.GetComponent<Animator>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       if(gameObject.tag=="dugme1")
        {
            if (a == 0)
            {
                m_Animator.SetTrigger("Dugmee");
                _platformAnim.enabled = true;
                a++;
            }
        }
        if (gameObject.tag == "dugme2")
        {
            if(b==0)
            {
                m_Animator.SetTrigger("Dugmee");
                b++;
                _box1Anim.enabled = true;
                _box2Anim.enabled = true;
            }

        }
 







    }
    private void OnCollisionExit2D(Collision2D collision)
    {
       // _dugme.GetComponent<Animator>().SetBool("Dugme", false);
    }

}
