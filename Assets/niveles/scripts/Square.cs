using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    private GameGrid grid;

    private void Awake()
    {
        grid = FindObjectOfType<GameGrid>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 clickPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            PlaceQuadNear(clickPoint);
        }
    }

    private void PlaceQuadNear(Vector2 clickPoint)
    {
        var finalPosition = grid.GetNearestPointOnGrid(clickPoint);

        // Create a quad at the finalPosition (2D plane)
        GameObject quad = GameObject.CreatePrimitive(PrimitiveType.Quad);
        quad.transform.position = new Vector3(finalPosition.x, finalPosition.y,-0.001f);

        // You may need to set the rotation to make the quad face the camera.
        quad.transform.eulerAngles = new Vector3(0f, 0f, 0f);
    }
}