using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ui_StartPanel : MonoBehaviour
{
    [Header("Buttons")]
    [SerializeField] private Button playButton;
    [SerializeField] private Button settingsButton;
    [SerializeField] private Button creditsButton;

    [Header("Panels")]
    [SerializeField] private GameObject settingsPanel;
    [SerializeField] private GameObject creditsPanel;
    [SerializeField] private GameObject pointsPanel;

    [Header("Sound")]
    [SerializeField] private AudioClip click;

    private void Awake() {
        Time.timeScale = 0;
    }
    void Start()
    {
        playButton.onClick.AddListener(OnPlayButtonClicked);
        settingsButton.onClick.AddListener(OnSetButtonClicked);
        creditsButton.onClick.AddListener(OnCredButtonClicked);
    }
    private void OnDestroy()
    {
        playButton.onClick.RemoveAllListeners();
        settingsButton.onClick.RemoveAllListeners();
        creditsButton.onClick.RemoveAllListeners();
    }
    private void OnPlayButtonClicked()
    {
        Audio_Controller.Instance.PlaySound(click);
        gameObject.SetActive(false);
        pointsPanel.SetActive(true);
        Time.timeScale = 1f;
    }
    private void OnCredButtonClicked()
    {
        Audio_Controller.Instance.PlaySound(click);
        creditsPanel.SetActive(true);
    }
    private void OnSetButtonClicked()
    {
        Audio_Controller.Instance.PlaySound(click);
        settingsPanel.SetActive(true);
    }
}
