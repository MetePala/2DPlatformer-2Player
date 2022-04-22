using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] GameObject player1camera, player2camera;
    [SerializeField] GameObject _player1, player2;

    private void FixedUpdate()
    {
        if (player2.transform.position.y <= _player1.transform.position.y)
        {
            player1camera.SetActive(false);
            player2camera.SetActive(true);
        }
        else
        {
            player2camera.SetActive(false);
            player1camera.SetActive(true);
        }
    }
}
