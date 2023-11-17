using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBarrier : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
       
        if (other.CompareTag("Enemy"))
        {
          
            Debug.Log("¡El jugador ha entrado en la barrera de muerte!");
           
        }
    }


    private void OnTriggerStay(Collider other)
    {
       
    }

  
    private void OnTriggerExit(Collider other)
    {
    }
}

