using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class Movement2D : MonoBehaviour
{
    [SerializeField]
    private float           moveSpeed;
    private Rigidbody2D     rigidbody2D;

    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    public void MoveTo(float x)
    {
        rigidbody2D.velocity = new Vector2(x * moveSpeed, rigidbody2D.velocity.y);
    }
}
