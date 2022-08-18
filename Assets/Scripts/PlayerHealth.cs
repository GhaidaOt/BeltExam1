using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float playerHealth;
    [SerializeField] GameObject gameOver;
    [SerializeField] GameObject win;

    public PlayerMovement pm;
    [SerializeField] Image healthBar;


    private void Update()
    {

        healthBar.fillAmount = playerHealth;

        if (playerHealth <= 0)
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

        if (collision.gameObject.CompareTag("Goal"))
        {
            win.SetActive(true);
            pm.enabled = false;
        }
    }
}
