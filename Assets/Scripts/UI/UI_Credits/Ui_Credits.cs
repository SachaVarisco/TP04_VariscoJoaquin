using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ui_Credits : MonoBehaviour
{
    [Header("Buttons")]
    [SerializeField] private Button backCredButton;

    [Header("Sound")]
    [SerializeField] private AudioClip click;

    void Start()
    {
        backCredButton.onClick.AddListener(OnBackButtonClicked);
    }

    private void OnDestroy()
    {
        backCredButton.onClick.RemoveAllListeners();
    }

    private void OnBackButtonClicked()
    {
        Audio_Controller.Instance.PlaySound(click);
        gameObject.SetActive(false);

    }
}
