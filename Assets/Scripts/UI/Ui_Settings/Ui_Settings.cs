using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Ui_Settings : MonoBehaviour
{
    /*[Header("PausePanel")]
    [SerializeField] private GameObject pausePanel;*/

    [Header("Sliders")]
    [SerializeField] private Slider soundSlider;
    [SerializeField] private Slider musicSlider;

    [Header("Button")]
    [SerializeField] private Button backSetButton;

    [Header("Sound")]
    [SerializeField] private AudioClip click;

    void Start()
    {
        backSetButton.onClick.AddListener(OnBackButtonClicked);
        soundSlider.onValueChanged.AddListener(OnSoundSliderChanged);
        musicSlider.onValueChanged.AddListener(OnMusicSliderChanged);
    }

    private void OnDestroy()
    {
        backSetButton.onClick.RemoveAllListeners();
        soundSlider.onValueChanged.RemoveAllListeners();
        musicSlider.onValueChanged.RemoveAllListeners();
    }

    // volume Functions
    private void OnSoundSliderChanged(float volume)
    {
        //Cambiar volumen de sonido
        Audio_Controller.Instance.SetVolume(volume);
    }
    private void OnMusicSliderChanged(float volume)
    {
        //Cambiar volumen de musica
        Music_Controller.Instance.SetVolume(volume);
    }


    private void OnBackButtonClicked()
    {
        Audio_Controller.Instance.PlaySound(click);
        gameObject.SetActive(false);
    }

}
