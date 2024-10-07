using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObjstacleSpawner : MonoBehaviour
{
    [Header("Obstacles")]
    [SerializeField] private GameObject[] obstacles;

    [Header("Timer")]
    [SerializeField] private float minTime;
    [SerializeField] private float maxTime;
    private float timeSpawn;
    private void Start()
    {
        StartCoroutine("SpawnObstacle");
    }

    private IEnumerator SpawnObstacle()
    {
        while (true)
        {
            int index = Random.Range(0, obstacles.Length);
            
            if (!obstacles[index].activeInHierarchy)
            {
                obstacles[index].transform.position = transform.position;
                obstacles[index].SetActive(true);
            }   
            timeSpawn = Random.Range(minTime, maxTime);
            yield return new WaitForSeconds(timeSpawn);
        }
    }
}
