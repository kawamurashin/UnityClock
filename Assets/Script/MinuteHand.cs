using UnityEngine;
using System.Collections;
using System;
public class MinuteHand : Hand {


    // Use this for initialization
    void Start () {
        transform.Translate(new Vector3(0.8f, 0, 0));
    }
	
	// Update is called once per frame
	void Update () {
	    
	}

    override public void setHandRotation(DateTime dateTime)
    {
        float value = getMinuteRotation(dateTime);
        handRotation(value);
    }
    override public void setIntHandRotation(DateTime dateTime)
    {
        float value = getMinuteRotation(dateTime);
        intRotation(value);
    }
}
