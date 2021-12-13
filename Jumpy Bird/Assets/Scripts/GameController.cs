using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Vector2 ScreenBounds { get; set; }

    public GameObject PipePrefab;
    public float SpawnDelay = 5f;
    public float SpawnTime = 0f;

    Bird bird;

    // Start is called before the first frame update
    void Start()
    {
        bird = FindObjectOfType<Bird>();

        ScreenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.x));

        InvokeRepeating("SpawnPipe", SpawnTime, SpawnDelay);
    }

    void SpawnPipe()
    {
        if (!bird.IsDead)
        {
            var spawnPoint = new Vector2(ScreenBounds.x + 5, Random.Range(-ScreenBounds.y + 3, ScreenBounds.y - 2));

            Instantiate(PipePrefab, spawnPoint, PipePrefab.transform.rotation);
        }
    }
}
