using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTouch : MonoBehaviour
{
    private Health health;
    private float damage = 1f;

    private void Start()
    {
        health = GetComponent<Health>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            health.GetDamage(damage);
            Debug.Log("Враг!");
        }
    }
}
