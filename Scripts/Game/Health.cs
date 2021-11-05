using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private Text uiHealth;
    private float health = 10f;

    private void Start()
    {
        HealthCheck();
    }

    public void GetDamage(float damage)
    {
        HealthChange(-damage);
    }

    private void HealthChange(float value)
    {
        health += value;
        HealthCheck();
    }

    private void HealthCheck()
    {
        if(health <= 0f)
        {
            health = 0;
            Dead();
        }

        uiHealth.text = health.ToString();
    }

    private void Dead()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
