using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdCode : MonoBehaviour
{
  public Rigidbody2D myRigidBody2D;
  private float flapForce = 18;
  public LogicScript logic;
  private bool isGameOver = false;


  // Frame Events:

  void Update()
  {
    if (Input.GetKeyDown(KeyCode.Space) && !isGameOver)
    {
      myRigidBody2D.velocity = new Vector2(0, 1) * flapForce;
    }
  }

  // Global Bird Event Hanlers

  void OnCollisionEnter2D(Collision2D collisionInfo)
  {
    logic.gameOver();
    isGameOver = true;
  }

  void OnBecameInvisible()
  {
    logic.gameOver();
    isGameOver = true;
  }
}
