using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Sceneswitch : MonoBehaviour
{

   public void go2game()
    {
        Debug.Log("Werkt");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    //reasons SceneManager.LoadScene("OtherSceneName", LoadSceneMode.Additive);

}
