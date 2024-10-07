using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawner : MonoBehaviour
{
    [Header("Power up")]
    [SerializeField] private GameObject powerUp;
    [SerializeField] private int appearChance;

    [Header("Timer")]
    [SerializeField] private float totalTime;
    private float actualTime;

    private void Start()
    {
        actualTime = totalTime;
    }

    private void Update()
    {
        actualTime -= Time.deltaTime;
        if (actualTime <= 0)
        {
            int index = Random.Range(0, 100);
            if (index <= appearChance && !powerUp.activeSelf)
            {
                powerUp.transform.position = gameObject.transform.position;
                powerUp.SetActive(true);
            }
            actualTime = totalTime;
        }
    }

}
