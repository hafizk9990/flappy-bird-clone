using UnityEngine;

public class MiddleScript : MonoBehaviour
{
  public LogicScript logic;

  void Start()
  {
    logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
  }

  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.gameObject.layer == 3)
    {
      /*
        Layer 3 is the bird in Unity.
        Layer 6 are the wings. When they pass, no score is updated.
      */
      logic.updateScore(1);
    }
  }
}
