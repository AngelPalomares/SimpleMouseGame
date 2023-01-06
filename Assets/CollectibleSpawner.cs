using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleSpawner : MonoBehaviour
{
    public GameObject Collectable;
    public GameObject BadCollectable;

    public float CollectibleSpawntime = 1.0f;
    public float badCollectibleSpawnTime = 2.0f;

    public bool canSpawnCollectible = true;
    public bool BadCollectible = true;

    float RandomXCollectible = 0.0f;
    float RandomYCollectible = 0.0f;

    float RandomXBadCollectible = 0.0f;
    float RandomYBadCollectible = 0.0f;

    float MaxX = 16.5f;
    float MaxY = 9.0f;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnCollectibles());
        StartCoroutine(SpawnBadCollectibles());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator spawnCollectibles()
    {
        while(canSpawnCollectible == true)
        {
            SpawnTheCollectible();
            yield return new WaitForSeconds(CollectibleSpawntime);


        }
    }

    IEnumerator SpawnBadCollectibles()
    {
        while(BadCollectible == true)
        {
            SpawnBadCollectible();
            yield return new WaitForSeconds(badCollectibleSpawnTime);
        }
    }

    public void SpawnTheCollectible()
    {
        RandomXCollectible = Random.Range(-MaxX, MaxX);
        RandomYCollectible = Random.Range(-MaxY, MaxY);

        Instantiate(Collectable, new Vector3(RandomXCollectible, RandomYCollectible, 0f), Quaternion.identity);

    }

    public void SpawnBadCollectible()
    {
        RandomXBadCollectible = Random.Range(-MaxX, MaxX);
        RandomYBadCollectible = Random.Range(-MaxY, MaxY);

        Instantiate(BadCollectable, new Vector3(RandomXBadCollectible, RandomYBadCollectible, 0f), Quaternion.identity);
    }

}
