using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    public float backspd;
    bool ismoving_ = false;
    // Start is called before the first frame update
    void Start()
    {
        speed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (speed == 0 && backspd == 0)
        {
            ismoving_ = false;
        }

        if (0 > speed)
        {
            speed = 0;
        }

        if (0 > backspd)
        {
            backspd = 0;
        }
        if (Input.GetKeyUp(KeyCode.W) == false)
        {

            StartCoroutine("accel");

        }

        if (Input.GetKeyUp(KeyCode.S) == false)
        {

            StartCoroutine("slowback");

        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            ismoving_ = true;
            StopCoroutine("accel");
            speed = 14;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-1 * Vector3.forward * Time.deltaTime * backspd);
            ismoving_ = true;
            backspd = 14;
            StopCoroutine("slowback");
        }





    }

    public IEnumerator accel()
    {
        while (enabled)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);

            yield return new WaitForSeconds(1f);


            if (speed > 0)
            {
                speed = speed - 0.22f;
            }
            yield return new WaitForSeconds(1f);
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }


    }
    public IEnumerator slowback()
    {
        while (enabled)
        {
            transform.Translate(-1 * Vector3.forward * Time.deltaTime * backspd);

            yield return new WaitForSeconds(1f);


            if (backspd > 0)
            {
                backspd = backspd - 0.2f;
            }
            yield return new WaitForSeconds(1f);

        }

    }

    private void OnCollisionStay(Collision other)
    {/*

        if (other.gameObject.tag == "Booster")
        {
            Debug.Log("Enter");
            speed = 24;
            backspd = 24;
            if (Input.GetKey(KeyCode.A) && ismoving_ == true)
            {
                transform.Rotate(0, -1f, 0);
            }
            if (Input.GetKey(KeyCode.D) && ismoving_ == true)
            {
                transform.Rotate(0, 1f, 0);

            }
        }
        */

        if (other.gameObject.tag == "Floorthingy")
        {
            if (Input.GetKey(KeyCode.A) && ismoving_ == true)
            {
                transform.Rotate(0, -1f, 0);
            }
            if (Input.GetKey(KeyCode.D) && ismoving_ == true)
            {
                transform.Rotate(0, 1f, 0);
            }


        }

    }



    

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Floorthingy")
        {
            ismoving_ = false;
            Debug.Log("AAAAAAAAAAAAAAAAAAAA");
            backspd = 0;
            speed = 0;
        }




    }
}
