using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpCpntroll : MonoBehaviour
{
    [Header ("Speed")]
    [SerializeField] private float scrollSpeed;

    [Header("Sound")]
    [SerializeField] private AudioClip Collected; 

    private void Update() {
        transform.Translate(Vector2.left * scrollSpeed * Time.deltaTime);
        if (transform.position.x < 0)
        {
            gameObject.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.layer == 8)
        {
            Audio_Controller.Instance.PlaySound(Collected);
            other.gameObject.GetComponent<Player_PowerUp>().PowerUp();
            gameObject.SetActive(false);
            
        }
    }
}
