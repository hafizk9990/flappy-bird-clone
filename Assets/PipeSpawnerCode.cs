using UnityEngine;

public class PipeSpawnerCode : MonoBehaviour
{
  public GameObject pipePreFab;

  /*
    A pre-fabricated asset was once a standalone game object, 
    with nested objects. We imported it as an asset in the game, 
    and then attached it with another game object in Unity engine
    using the code above.
  */

  private float pipeSpawnTime = 1.75f; // "f" converts the number to a float from double.
  private float timer = 0;
  private float offset = 9;

  void Start()
  {
    instantiatePipe();
  }

  void Update()
  {
    spawnMorePipePairs();
  }

  void spawnMorePipePairs()
  {
    if (timer < pipeSpawnTime)
    {
      timer += Time.deltaTime;
    }
    else
    {
      instantiatePipe();
      timer = 0;
    }
  }

  void instantiatePipe()
  {
    float minYOffset = transform.position.y - offset;
    float maxYOffset = transform.position.y + offset;
    Instantiate(pipePreFab, new Vector3(transform.position.x, Random.Range(minYOffset, maxYOffset), 0), transform.rotation);
  }
}
