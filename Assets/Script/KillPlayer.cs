using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class KillPlayer : MonoBehaviour
{
    
    public bool isGameOver;
    public GameObject gameOverUI;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("KillPlayer"))
        {
            isGameOver = true;
            gameOverUI.SetActive(true);
            die();
            GetComponent<CameraController>().DisableOrDeleteScript();
        }
    }

    private void die()
    {
        Destroy(gameObject);
    }
    
}
