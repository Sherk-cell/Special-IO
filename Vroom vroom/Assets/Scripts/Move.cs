using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{


    public float floater = 12;
    public bool inair;
    void Start()
    {

    }

    void Update()
    {
        if(inair == true)
        {
            StartCoroutine("Floating");

        }
        

       


    }


    public IEnumerator Floating()
    {
        while (enabled)
        {

            Debug.Log("werkt");
            transform.Translate(Vector3.forward * Time.deltaTime * floater);
            yield return new WaitForSeconds(1f);
            if (floater > 0)
            {
                floater = floater - 0.022f;
            }
        }
    }





    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Floorthingy")
        {
            Debug.Log("aaa");
            inair = true;
        }


    }



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floorthingy")
        {
            inair = false;
            StopCoroutine("Floating");
            floater = 12;
            Debug.Log("opgrond");
        }
    }

    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "Floorthingy")
        {
            if(inair == false)
            {
                transform.Translate(0, 0, -Input.acceleration.z);
                transform.Rotate(0, Input.acceleration.x, 0);

            }

            inair = false;

           

        }
    }
}
