using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    [Header ("Data")]
    public Player_Data playerData;

    [Header ("GameOver panel")]
    [SerializeField] private GameObject gameOverPanel;
    public bool CanGetHit;

    [Header("Components")]
    private Animator animator;

    private void Awake() {
        animator = GetComponent<Animator>();
    }

    private void GameOver(){
        Time.timeScale = 0;
        gameOverPanel.SetActive(true);
    }

    public void Hitted(){
        Audio_Controller.Instance.PlaySound(playerData.hurtSound);
        animator.SetTrigger("Death");
    }

}
