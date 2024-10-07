using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
    [SerializeField] private Vector2 speedMove;
    private Vector2 offset;
    private Material material;

    private void Awake() {
        material = GetComponent<SpriteRenderer>().material;
    }
    private void Update() {
        offset = speedMove * Time.deltaTime;
        material.mainTextureOffset += offset;

    }
}
