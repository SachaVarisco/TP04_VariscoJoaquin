using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Up_DownMove : MonoBehaviour
{
    [Header ("Lerp")]
    private float lerpDuration;
    [SerializeField] private int target;


    private void Update()
    {
        StartCoroutine(LerpPosition(new Vector2(transform.position.x, target), 1));
    }
    private IEnumerator LerpPosition(Vector2 target, float lerpDuration){
        float timeElapsed = 0f;
        while(timeElapsed < lerpDuration){
            transform.position = Vector2.Lerp(transform.position, target, timeElapsed / lerpDuration);
            timeElapsed += Time.deltaTime;
            yield return null;
        }
        
    }
}
