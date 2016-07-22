using UnityEngine;
using System.Collections;
using System;

public class Hand : MonoBehaviour {
    const float K = 0.5f;
    const float U = 0.5f;
    float vr = 0;
    protected float currentRotation = 0;
    public virtual void setHandRotation(DateTime dateTime)
    {
    }
    protected void handRotation(float targetRotation)
    {
        float dr =  (targetRotation - currentRotation);
        if(dr > 180)
        {
            currentRotation += 360;
            handRotation(targetRotation);
            return;
        }
        vr += K * dr - U * vr;
        transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, 0, 1), vr);
        currentRotation += vr;
    }
    public virtual void setIntHandRotation(DateTime dateTime)
    {
    }
    protected void intRotation(float value)
    {
        currentRotation = value;
        transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, 0, 1), value);
    }
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}


    protected float getHourRotation(DateTime dateTime)
    {
        int h = dateTime.Hour;
        int m = dateTime.Minute;
        int s = dateTime.Second;
        float value = 90 + (-360 * (float)(h) / 12) + (-(360 / 12) * ((float)(m) / 60)) + (-(360 / (12*60)) * ((float)(s) / 60));
        return value;
    }
    protected float getMinuteRotation(DateTime dateTime)
    {
        int m = dateTime.Minute;
        int s = dateTime.Second;
        float value = 90 + (-360 * (float)(m) / 60) + (-(360 / 60) * ((float)(s) / 60));
        return value;
    }
    protected float getSecondRotation(DateTime dateTime)
    {
        int s = dateTime.Second;
        float value = 90 + -360 * (float)(s) / 60;
        return value;
    }
}
