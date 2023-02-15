using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatAround : MonoBehaviour
{
    public float /*xMin, xMax, */yMin, yMax;
    private float /*x,*/ y, /*xdir=1,*/ ydir=1;
    [Range(-0.001f,0.05f)]public float /*xPow=0, */yPow=0;

    void FixedUpdate()
    {
        //x = transform.localPosition.x;
        y = transform.localPosition.y;

        /*if (x < xMin || x > xMax)                     // this is exactly
        {
            xdir *= -1;
        }*/

        ydir = (y<yMin+0.5f || y > yMax-0.5f) ? ydir*-1 : ydir;   // the same thing

        transform.Translate(new Vector3(0, ydir*yPow, 0));

    }
}
