using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_PowerUp : MonoBehaviour
{
    [Header ("Data")]
    private Player_Data playerData;

    [Header ("Can get hit")]
    private Player_Controller playerControl;

    [Header ("Components")]
    private Animator animator;
    

    private void Awake() {
        animator = GetComponent<Animator>();
        playerData = GetComponent<Player_Controller>().playerData;
        playerControl = GetComponent<Player_Controller>();
    }
    private IEnumerator Invincible(){
        Music_Controller.Instance.PlayMusic(playerData.starMusic);
        playerControl.CanGetHit = false;
        animator.SetBool("Invencible", true);
        playerData.pointsPerPlus = 3;
        yield return new WaitForSeconds(playerData.invencibleTime);
        playerControl.CanGetHit = true;
        animator.SetBool("Invencible", false);
        Music_Controller.Instance.PlayAwake();
        playerData.pointsPerPlus = 1;
    }
    public void PowerUp(){
        StartCoroutine("Invincible");
    }
}
