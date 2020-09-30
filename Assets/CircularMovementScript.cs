using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularMovementScript : MonoBehaviour
{
    public float t = 0f;
    float x, z;
    public float speed = 1f;
    public float radius1 = 3f;
    public float radius2 = 3f;
    public Vector3 center;
    public char axis = 'x';
    
    // Start is called before the first frame update
    void Start()
    {
        center = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime * speed;
        x = radius1 * Mathf.Cos(t);
        z = radius2 * Mathf.Sin(t);

        if (axis == 'x')
            transform.position = new Vector3(0,x,z) + center;
        if (axis == 'y')
            transform.position = new Vector3(x, 0, z) + center;
        if (axis == 'z')
            transform.position = new Vector3(z, x, 0) + center;

        if (t >= 314)
        {
            t = 0f;
        }
    }
}
