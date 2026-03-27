using UnityEngine;

public class SegmentObstacleSpawner : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;
    public float spawnChance = 0.6f; // 60% chance

    void Start()
    {
        SpawnObstacles();
    }

    void SpawnObstacles()
    {
        foreach (Transform child in transform)
        {
            if (child.name.StartsWith("ObstaclePoint"))
            {
                if (Random.value < spawnChance)
                {
                    GameObject obstacle = Instantiate(
                        obstaclePrefabs[Random.Range(0, obstaclePrefabs.Length)],
                        child.position,
                        child.rotation
                    );

                    obstacle.transform.SetParent(transform); // keep organized
                }
            }
        }
    }
}