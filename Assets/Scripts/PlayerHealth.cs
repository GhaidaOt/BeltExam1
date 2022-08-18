using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float playerHealth;
    [SerializeField] GameObject gameOver;
    public PlayerMovement pm;

    private void Update()
    {
        if(playerHealth <= 0)
        {
            gameOver.SetActive(true);
            pm.enabled = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            playerHealth -= 1/3f;

        }
    }
}
