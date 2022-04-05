using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DEAT : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("AAA");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);

        }
    }

}
