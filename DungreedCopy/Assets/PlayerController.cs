using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerMovement2D        movement2D;

    private void Awake()
    {
        movement2D = GetComponent<PlayerMovement2D>();
    }

    private void Update()
    {
        UpdateMove();
    }

    public void UpdateMove()
    {
        float x = Input.GetAxisRaw("Horizontal");

        movement2D.MoveTo(x);
    }
}
