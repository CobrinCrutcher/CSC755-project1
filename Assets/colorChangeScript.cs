using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

public class colorChangeScript : MonoBehaviour
{
    float r, g, b = 0f;
    public float speed = 1f;

    bool rUp, rDown, gUp, gDown, bUp, bDown = false;

    // Start is called before the first frame update
    void Start()
    {
        r = 1f;
        speed /= 1000f;
    }

    // Update is called once per frame
    void Update()
    {
        cycleColor();
        GetComponent<Renderer>().material.color = new Color(r, g, b);
    }
    
    void cycleColor()
    {
        if(r == 1 && g == 0 && b == 0)
        {
            bDown = false;
            gUp = true;
        }
        if (r == 1 && g == 1 && b == 0)
        {
            gUp = false;
            rDown = true;
        }
        if (r == 0 && g == 1 && b == 0)
        {
            rDown = false;
            bUp = true;
        }
        if (r == 0 && g == 1 && b == 1)
        {
            bUp = false;
            gDown = true;
        }
        if (r == 0 && g == 0 && b == 1)
        {
            gDown = false;
            rUp = true;
        }
        if (r == 1 && g == 0 && b == 1)
        {
            rUp = false;
            bDown = true;
        }




        if (rDown)
        {
            r -= speed;
            r = Mathf.Clamp(r, 0, 1);
        }
        if (gDown)
        {
            g -= speed;
            g = Mathf.Clamp(g, 0, 1);
        }
        if (bDown)
        {
            b -= speed;
            b = Mathf.Clamp(b, 0, 1);
        }
        if (rUp)
        {
            r += speed;
            r = Mathf.Clamp(r, 0, 1);
        }
        if (gUp)
        {
            g += speed;
            g = Mathf.Clamp(g, 0, 1);
        }
        if (bUp)
        {
            b += speed;
            b = Mathf.Clamp(b, 0, 1);
        }

        //Debug.Log(r+" "+g+" "+ b);
    }
}
