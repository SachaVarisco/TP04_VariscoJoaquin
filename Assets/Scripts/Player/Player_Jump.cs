using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Jump : MonoBehaviour
{
    [Header ("Feets")]
    [SerializeField] private Transform feetsPos;

    [Header ("Data")]
    private Player_Data playerData;

    [Header ("Components")]
    private Rigidbody2D rb2D;
    private Animator animator;

    private void Awake() {
        playerData = GetComponent<Player_Controller>().playerData;
        rb2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void Update() {
        bool isGrounded = Physics2D.OverlapCircle(feetsPos.position, playerData.feetRadius, playerData.ground);
        animator.SetFloat("MoveY", rb2D.velocity.y); 
        animator.SetBool("IsGrounded", isGrounded);

        
        if (Input.GetKeyDown(playerData.jumpKey) && isGrounded)
        {
            Audio_Controller.Instance.PlaySound(playerData.jumpSound);
            rb2D.AddForce(Vector2.up * playerData.jumpForce);
        }
    }

    /*private void OnDrawGizmos() {
        Gizmos.DrawWireSphere(feetsPos.position, playerData.feetRadius);

    }*/
}
