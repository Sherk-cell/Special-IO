using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class Move : MonoBehaviour
{

    public AudioSource Audios;
    public float floater = 12;
    public bool inair;
    void Start()
    {
        AudioSource source = gameObject.GetComponent<AudioSource>();

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
                transform.Rotate(0, Input.acceleration.x * 1.5f, 0);
                if (Input.acceleration.z > 0.0000001f)
                {
                    Audios.Play(0);
                    Debug.Log(Input.acceleration.z);
                   
                }
            
            }

            inair = false;

           

        }
    }
}
