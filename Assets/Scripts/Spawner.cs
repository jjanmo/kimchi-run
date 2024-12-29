using UnityEngine;

public class Spawner : MonoBehaviour
{

    [Header("Settings")]
    public float minSpawnDelay;
    public float maxSpawnDelay;

    [Header("References")]
    public GameObject[] gameObjects;

    void Start()
    {
        Invoke("Spawn", 1f);
    }

    void Spawn()
    {
        // generate game object
        GameObject randomObject = gameObjects[Random.Range(0, gameObjects.Length)];
        Instantiate(randomObject, transform.position, Quaternion.identity);

        // render(spawn) the game object in scene
        Invoke("Spawn", Random.Range(minSpawnDelay, maxSpawnDelay));
    }
}
