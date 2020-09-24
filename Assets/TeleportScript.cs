using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScript : MonoBehaviour
{
    public float teleportHeight = 2f;

    public Transform playerBody;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, 100f))
            {
                
                Debug.Log(hit.distance);
                if (hit.collider.tag == "TeleportLocation")
                {
                    playerBody.transform.position = hit.collider.transform.position + Vector3.up * teleportHeight;
                    //playerBody.transform.position.Set(playerBody.transform.position.x, playerBody.transform.position.y + teleportHeight, playerBody.transform.position.z);
                    
                }
            }
        }
    }
}
