using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] cubes; //Array stroing all cubes that spawn
    public float spawnRangeX; //Range on the X-axis where cubes spawn
    public float spawnRangeZ; //Range on the Z-axis werhe cubes spawn
    public int spawnStartDelay; //Number of seconds after which the spawns start
    public int spawnInterval; //Number of seconds before the next spawn
    public string cubeName; //String containing the cube prefab name
    private int cubeCount; //Integer counting the nubmer of cubes that have spawned
    private int waveNumber;// Integer counting the number of waves

    private void Start()
    {
        InvokeRepeating("SpawnRandomCube", spawnStartDelay, spawnInterval);
    }

    private void SpawnRandomCube()
    {
        int cubeIndex = Random.Range(0, cubes.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 1, Random.Range(-2, spawnRangeZ));
        Instantiate(cubes[cubeIndex], spawnPos, cubes[cubeIndex].transform.rotation);
        cubeName = cubes[cubeIndex].name;
        Debug.Log(cubeName + " was spawned.");
    }
}
