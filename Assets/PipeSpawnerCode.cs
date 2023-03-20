using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerCode : MonoBehaviour
{
  public GameObject pipePreFab; // Pre-fabricated asset, pipe
  private float pipeSpawnTime = 1.5f;
  private float timer = 0;
  private float offset = 8;

  // Start is called before the first frame update
  void Start()
  {
    instantiatePipe();
  }

  // Update is called once per frame
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
