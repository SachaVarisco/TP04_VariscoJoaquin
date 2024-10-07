using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Player_Slide : MonoBehaviour
{
    [Header ("Box size")]
    private float boxHeightInit;

    [Header ("Data")]
    private Player_Data playerData;

    [Header ("Components")]
    private CapsuleCollider2D boxColl2D;
    private Animator animator;

    private void Awake() {
        boxColl2D = GetComponent<CapsuleCollider2D>();
        boxHeightInit = boxColl2D.size.y;
        animator = GetComponent<Animator>();
        playerData = GetComponent<Player_Controller>().playerData;
    }

    private void Update() {
        if (Input.GetKeyDown(playerData.slideKey))
        {
            StartCoroutine("Slide");
        }
    }

    private IEnumerator Slide(){
        Audio_Controller.Instance.PlaySound(playerData.slideSound);
        boxColl2D.size = new Vector2(boxColl2D.size.x, playerData.boxHeight);
        animator.SetBool("Slide", true);
        yield return new WaitForSeconds(playerData.slideTime);
        boxColl2D.size = new Vector2(boxColl2D.size.x, boxHeightInit);
        animator.SetBool("Slide", false);
    }
}
