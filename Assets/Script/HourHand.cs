using UnityEngine;
using System.Collections;
using System;
public class HourHand : Hand
{

    // Use this for initialization
    void Start()
    {
        transform.Translate(new Vector3(0.5f, 0, 0));
    }

    // Update is called once per frame
    void Update()
    {

    }
    override public void setHandRotation(DateTime dateTime)
    {
        float value = getHourRotation(dateTime);
        handRotation(value);
    }

    override public void setIntHandRotation(DateTime dateTime)
    {
        float value = getHourRotation(dateTime);
        intRotation(value);
    }
}
