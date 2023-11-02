using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Movement2D      movement;
    private void Awake()
    {
        movement = GetComponent<Movement2D>();    
    }

    private void Update()
    {
        UpdateMove();
    }

    public void UpdateMove()
    {
        float x = Input.GetAxis("Horizontal");

        movement.MoveTo(x);
    }
}
