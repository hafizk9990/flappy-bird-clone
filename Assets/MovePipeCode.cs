using UnityEngine;

public class MovePipeCode : MonoBehaviour
{
  private float transformationSpeed = 10;
  private float deadZone = -35;

  void Update()
  {
    transform.position = transform.position + (Vector3.left * transformationSpeed) * Time.deltaTime;

    if (transform.position.x < deadZone)
    {
      Destroy(gameObject); // free up memory
    }
  }
}
