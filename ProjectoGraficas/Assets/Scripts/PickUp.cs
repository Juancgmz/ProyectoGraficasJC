using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Transform theDest;

    void OnMouseDown()
    {
        try
        {
            GetComponent<BoxCollider>().enabled = false;
        }
        catch (System.Exception e)
        {

        }

        try
        {
            GetComponent<SphereCollider>().enabled = false;
        }
        catch (System.Exception e)
        {

        }

        try
        {
            GetComponent<CapsuleCollider>().enabled = false;
        }
        catch (System.Exception e)
        {

        }
        
        GetComponent<Rigidbody>().useGravity = false;
        this.transform.position = theDest.position;
        this.transform.parent = GameObject.Find("Destination").transform;
    }

    void OnMouseUp()
    {
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        try
        {
            GetComponent<BoxCollider>().enabled = true;
        }
        catch (System.Exception e)
        {

        }

        try
        {
            GetComponent<SphereCollider>().enabled = true;
        }
        catch (System.Exception e)
        {

        }

        try
        {
            GetComponent<CapsuleCollider>().enabled = true;
        }
        catch (System.Exception e)
        {

        }
    }
}
