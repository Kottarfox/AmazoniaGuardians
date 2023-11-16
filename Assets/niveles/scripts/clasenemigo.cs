using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ClaseEnemigo : MonoBehaviour
{
    public Rigidbody2D rb;

    public int vida;
    public int daño;
    public int rango;
    public int spawnTime;
    public float moveSpeed;
    public Vector2 position;

    public void Mover(float moveSpeed)
    {
        position.x = position.x + Time.deltaTime * moveSpeed * -1;
        rb.MovePosition(position);

    }
    public virtual void Ataque(int daño)
    {

    }
}