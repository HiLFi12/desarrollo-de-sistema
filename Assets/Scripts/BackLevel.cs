using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackLevel : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            int escena = SceneManager.GetActiveScene().buildIndex;
            escena--;
            SceneManager.LoadScene(escena);
        }
    }
}
