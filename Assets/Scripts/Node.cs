using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public LayerMask obstacleLayer;
    public List<Vector2> availableDirections { get; private set; }

    private void Start()
    {
        this.availableDirections = new List<Vector2>();

        CheckAvaiableDirection(Vector2.up);
        CheckAvaiableDirection(Vector2.down);
        CheckAvaiableDirection(Vector2.left);
        CheckAvaiableDirection(Vector2.right);
    }

    private void CheckAvaiableDirection(Vector2 direction)
    {
        RaycastHit2D hit = Physics2D.BoxCast(this.transform.position, Vector2.one * 0.5f, 0.0f, direction, 1.0f, this.obstacleLayer);

        if (hit.collider == null)
        {
            this.availableDirections.Add(direction);
        }
    }
}
