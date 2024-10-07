using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "Player/Data",order = 1)]
public class Player_Data : ScriptableObject
{
    [Header ("Points")]
    public int pointsPerPlus;

    [Header ("Jump")]
    public int jumpForce; 
    public KeyCode jumpKey;
    public float feetRadius;
    public LayerMask ground;

    [Header ("Slide")]
    public float slideTime;
    public KeyCode slideKey;

    public float boxHeight;

    [Header ("PowerUp")]
    public float invencibleTime;

    [Header ("Sounds")]

    public AudioClip jumpSound;
    public AudioClip hurtSound;
    public AudioClip slideSound;
    public AudioClip runSound;
    public AudioClip landSound;

    [Header ("Music")]
    public AudioClip starMusic;

}
