using UnityEngine;

public class MovePipeCode : MonoBehaviour
{
  private float transformationSpeed = 10;
  private float deadZone = -35;
  public BirdCode bird;

  void Start()
  {
    bird = GameObject.FindGameObjectWithTag("Bird").GetComponent<BirdCode>();
  }

  void Update()
  {
    if (!bird.isGameOver)
    {
      transform.position = transform.position + (Vector3.left * transformationSpeed) * Time.deltaTime;
    }

    if (transform.position.x < deadZone)
    {
      Destroy(gameObject); // free up memory
    }
  }
}
