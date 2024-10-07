using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class UI_GameOver : MonoBehaviour
{
    [Header("Buttons")]
    [SerializeField] private Button restartButton;



    [Header("Text")]
    [SerializeField] private GameObject scoreGO;
    [SerializeField] private TextMeshProUGUI score;
    [SerializeField] private TextMeshProUGUI finalScore;

    [Header("Sound")]
    [SerializeField] private AudioClip click;

    void Start()
    {
        restartButton.onClick.AddListener(OnRestartButtonClicked);

    }
    private void OnEnable() {
        finalScore.text = score.text;
        scoreGO.SetActive(false);
    }
    private void OnDestroy()
    {
        restartButton.onClick.RemoveAllListeners();
    }
    private void OnRestartButtonClicked()
    {
        Audio_Controller.Instance.PlaySound(click);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
