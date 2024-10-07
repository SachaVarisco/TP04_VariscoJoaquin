using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class PointsController : MonoBehaviour
{
    [Header ("Data")]
    [SerializeField] private Player_Data playerData;
    [Header ("Points")]
    [SerializeField] private int points;


    [Header ("Text")]
    [SerializeField] private TextMeshProUGUI pointText;

    [Header ("Timer")]
    private float actualTime;
    private float totalTime = 0.5f;

    private void Start() {
        actualTime = totalTime;
        pointText.text = points.ToString();
    }

    private void Update() {
        actualTime -= Time.deltaTime;
        if (actualTime <= 0)
        {
            points += playerData.pointsPerPlus;
            pointText.text = points.ToString();
            actualTime = totalTime;
        }
    }
}
