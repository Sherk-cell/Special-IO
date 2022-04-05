using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testscript : MonoBehaviour
{
    //float smooth = 5f;


    void Update()
    {
        

       // transform.Translate(Input.acceleration.x, 0, -Input.acceleration.z);


        //Debug.Log("Z = " + Input.acceleration.z);

        if (Input.acceleration.x > 0.35f)
        {
            Debug.Log("rechts");
        }

        if (Input.acceleration.x < -0.35f)
        {
            Debug.Log("links");
        }

        if (Input.acceleration.z > 0.35f)
        {
            Debug.Log("achter");
          
        }

        if (Input.acceleration.z < -0.35f)
        {
            Debug.Log("voor");
        }




    }


}
