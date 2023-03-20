using UnityEngine;

public class MiddleScript : MonoBehaviour
{
  public LogicScript logic;
  public BirdCode bird;

  void Start()
  {
    logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    bird = GameObject.FindGameObjectWithTag("Bird").GetComponent<BirdCode>();
  }

  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.gameObject.layer == 3 && !bird.isGameOver)
    {
      /*
        Layer 3 is the bird in Unity.
        Layer 6 are the wings. When they pass, no score is updated.
      */
      logic.updateScore(1);
    }
  }
}
