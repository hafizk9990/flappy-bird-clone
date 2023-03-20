using UnityEngine;

public class BirdCode : MonoBehaviour
{
  public Rigidbody2D myRigidBody2D;
  private float flapForce = 20;
  public LogicScript logic;
  public bool isGameOver = false;

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
    isGameOver = true;
    logic.gameOver();
  }

  void OnBecameInvisible()
  {
    isGameOver = true;
    logic.gameOver();
  }
}
