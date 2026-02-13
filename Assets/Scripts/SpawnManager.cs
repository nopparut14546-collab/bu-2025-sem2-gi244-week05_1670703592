using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private int animalIndex;
    public float spawnRangeX = 15;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnAnimal2), 2f, 4f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SpawnAnimal2();
        }
    }

    void SpawnAnimal2()
    {
        animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new(
            Random.Range(-spawnRangeX, spawnRangeX),
            transform.position.y,
            transform.position.z);
        Instantiate(
            animalPrefabs[animalIndex],
            spawnPos,
            animalPrefabs[animalIndex].transform.rotation);
    }
}
