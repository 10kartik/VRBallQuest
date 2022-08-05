using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartOnCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision c)
    {
          SceneManager.LoadScene(SceneManager.GetActiveScene().name);    
    }
}
