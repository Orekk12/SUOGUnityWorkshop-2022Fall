using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float cooldown;
    public GameObject spawnPrefab;
    private BoxCollider2D boxCollider;
    private float lastSpawnTime;

    private void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }
    private void Update()
    {
        if (lastSpawnTime + cooldown <= Time.time)
        {
            lastSpawnTime = Time.time;
            Spawn();
        }
    }

    private void Spawn()
    {
        var spawnPos = FindSpawnPos();

        Instantiate(spawnPrefab, spawnPos, spawnPrefab.transform.rotation);
    }

    private Vector2 FindSpawnPos()
    {
        var posx = Random.Range(boxCollider.bounds.min.x, boxCollider.bounds.max.x);
        var posy = Random.Range(boxCollider.bounds.min.y, boxCollider.bounds.max.y);

        return new Vector2(posx, posy);
    }
}
