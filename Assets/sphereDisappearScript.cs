using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereDisappearScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //private void OnTriggerStay(Collider other)
    //{
    //    Debug.Log("triggered");
    //    if(other.gameObject.tag == "Orb")
    //    {
    //        other.gameObject.SetActive(false);
    //    }
    //}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Orb")
        {
            collision.gameObject.SetActive(false);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Orb")
        {
            collision.gameObject.SetActive(true);
        }
    }
}
