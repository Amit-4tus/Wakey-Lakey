using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Transform inFront;
    public Boolean isPickedUp = false;

     void pickUp()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown("e") && !isPickedUp)
        {
            GetComponent<CapsuleCollider>().enabled = false;
            GetComponent<Rigidbody>().useGravity = false;
            GetComponent<Rigidbody>().freezeRotation = true;
            this.transform.position = inFront.position;
            this.transform.parent = GameObject.Find("InFront").transform;
            isPickedUp = true;
        } else if (Input.GetKeyDown("e") && isPickedUp)
        {
            GetComponent<CapsuleCollider>().enabled = true;
            GetComponent<Rigidbody>().useGravity = true;
            GetComponent<Rigidbody>().freezeRotation = false;
            this.transform.parent = null;
            isPickedUp = false;
        }
    }
}
