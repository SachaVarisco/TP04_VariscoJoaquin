using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    [Header ("Speed")]
    [SerializeField] private float scrollSpeed;

    [Header ("Player")]
    [SerializeField] private Player_Controller playerControl;

    private void Update() {
        transform.Translate(Vector2.left * scrollSpeed * Time.deltaTime);
        if (transform.position.x < 0)
        {
            gameObject.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.layer == 8 && playerControl.CanGetHit)
        {
            playerControl.Hitted();
        }
    }
}
