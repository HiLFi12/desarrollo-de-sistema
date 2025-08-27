using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerCollisionHandler : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Point")){
            ScoreManager.instance.score++;
            Debug.Log(ScoreManager.instance.score);
        }
    }
}
