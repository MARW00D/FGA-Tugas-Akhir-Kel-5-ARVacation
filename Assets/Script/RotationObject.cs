using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationObject : MonoBehaviour
{
    public GameObject objectRotate;

    public float rotateSpeed = 50f;
    bool rotateStatus = false;

    //rotate object function
    public void RotateObject()
    {

        if (rotateStatus == false)
        {
            rotateStatus = true;
        }
        else
        {
            rotateStatus = false;
        }
    }

    void Update()
    {
        if (rotateStatus == true)
        {
            //kecepatan memutar object 
            objectRotate.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
            Debug.Log("sudah Pusing - Pusing Bro");
        }
    }
}