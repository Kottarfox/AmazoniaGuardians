using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameGrid : MonoBehaviour
{
    [SerializeField]
    private float size = 1f;
    public int valorx = 0;
    public int valory = 0;

    public Vector2 GetNearestPointOnGrid(Vector2 position)
    {
        Vector2 transformPosition2D = new Vector2(transform.position.x, transform.position.y);
        position -= transformPosition2D;

        int xCount = Mathf.RoundToInt(position.x / size);
        int yCount = Mathf.RoundToInt(position.y / size);


        Vector2 result = new Vector2(
            (float)xCount * size,
            (float)yCount * size
            );


        result += transformPosition2D;

        return result;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        for (float x = 0; x < valorx; x += size)
        {
            for (float y = 0; y < valory; y += size)
            {
                var point = GetNearestPointOnGrid(new Vector2(x, y));
                Gizmos.DrawSphere(point, 0.1f);
            }

        }
    }
}
