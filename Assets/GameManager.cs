using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject draggingObject;
    public GameObject currentContainer;

    public static GameManager Instance;

    private void Awake()
    {
        Instance = this;

    }

    public void PlaceObject()
    {
        if (draggingObject != null && currentContainer != null)
        {
            
        }

    }
}
