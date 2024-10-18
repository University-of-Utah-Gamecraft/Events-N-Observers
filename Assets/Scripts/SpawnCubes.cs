using UnityEngine;
using UnityEngine.UIElements;

public class SpawnCubes : MonoBehaviour
{
    public GameObject cube;

    private float spawnInterval = 1f;
    private float timer;
    private Vector3 spawnerPosition;

    void Start()
    {
        spawnerPosition = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > spawnInterval) 
        {
            timer = 0;
            float random = Random.Range(-3, 2);
            Vector3 randomPos = new Vector3(spawnerPosition.x, spawnerPosition.y + random, spawnerPosition.z);
            GameObject spawnedCube = Instantiate(cube, randomPos, Quaternion.identity);
            Destroy(spawnedCube, 10);
        }
    }
}
