using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2D : MonoBehaviour
{
    [SerializeField]
    private float               moveSpeed;

    private Rigidbody2D         rigidbody;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    public void MoveTo(float x)
    {
        rigidbody.velocity = new Vector2(x * moveSpeed, rigidbody.velocity.y);
    }
}
