using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
   
    private void OnCollisionEnter(Collision c)
    {

    //int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;   
    //if (SceneManager.sceneCount > nextSceneIndex)
    //{
    //    SceneManager.LoadScene(nextSceneIndex);
    //}


    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
