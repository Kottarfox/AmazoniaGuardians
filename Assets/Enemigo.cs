using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public float speed;
    public float health;
    public float damage;

    private void FixedUpdate()
    {
        transform.position -= new Vector3(speed, 0, 0);
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
    }

    public void Attack(aliado aliado)
    {

        aliado.TakeDamage(damage);
    }
}