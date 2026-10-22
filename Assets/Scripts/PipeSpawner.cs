using NUnit.Framework;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private float spawnInterval = 1.5f;
    [SerializeField] private float heightRange = 0.45f;
    [SerializeField] private GameObject pipePrefab;

    private float timer;

    private void Start()
    {
        SpawnPipe();
    }

    private void Update()
    {
        // spawn pipes on an interval
        if (timer > spawnInterval)
        {
            timer -= spawnInterval;
            SpawnPipe();
        }
        timer += Time.deltaTime;
    }

    private void SpawnPipe()
    {
        // get a random spawn position
        Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(-heightRange, heightRange));

        // create a new pipe
        GameObject pipe = Instantiate(pipePrefab, spawnPos, Quaternion.identity);

        // clear pipes after they get off screen
        Destroy(pipe, 10f);
    }

}
