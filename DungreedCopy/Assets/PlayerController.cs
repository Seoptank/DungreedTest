using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
<<<<<<< Updated upstream
    private PlayerMovement2D        movement2D;

    private void Awake()
    {
        movement2D = GetComponent<PlayerMovement2D>();
=======
    private Movement2D      movement;

    private void Awake()
    {
        movement = GetComponent<Movement2D>();
>>>>>>> Stashed changes
    }

    private void Update()
    {
        UpdateMove();
    }
<<<<<<< Updated upstream

    public void UpdateMove()
    {
        float x = Input.GetAxisRaw("Horizontal");

        movement2D.MoveTo(x);
=======
    public void UpdateMove()
    {
        float x = Input.GetAxis("Horizontal");

        movement.MoveTo(x);
>>>>>>> Stashed changes
    }
}
