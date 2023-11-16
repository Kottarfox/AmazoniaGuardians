using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Transform target;
    private int damage;


    
    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }

    public void SetDamage(int newDamage)
    {
        damage = newDamage;
    }

    void Update()
    {
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 direction = target.position - transform.position;
        float distanceThisFrame = Time.deltaTime * 10f; 
        transform.Translate(direction.normalized * distanceThisFrame, Space.World);

        if (Vector3.Distance(transform.position, target.position) < 0.2f)
        {
            HitTarget();
        }
    }

    void HitTarget()
    {
   
        Debug.Log("Proyectil golpeó al enemigo!");
        Destroy(gameObject);
    }
}
