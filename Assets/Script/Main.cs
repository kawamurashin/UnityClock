using UnityEngine;
using System.Collections;
using System;

public class Main : MonoBehaviour {

    Hand[] list;
    // Use this for initialization
    void Start () {
        uint i;
        int n;
        Hand hand;
        GameObject gameObject;
        //
        gameObject = Instantiate(Resources.Load("prefabs/MinuteHand")) as GameObject;
        MinuteHand minuteHand = gameObject.GetComponent<MinuteHand>();
        gameObject = Instantiate(Resources.Load("prefabs/SecondHand")) as GameObject;
        SecondHand secondHand = gameObject.GetComponent<SecondHand>();
        gameObject = Instantiate(Resources.Load("prefabs/HourHand")) as GameObject;
        HourHand hourHand = gameObject.GetComponent<HourHand>();
        //
        list = new Hand[]{ minuteHand, secondHand, hourHand };
        //
        DateTime dateTime = DateTime.Now;
        n = list.Length;
        for (i = 0; i < n; i++)
        {
            hand = list[i];
            hand.setIntHandRotation(dateTime);
        }
    }

    // Update is called once per frame
    void Update () {
        uint i;
        int n;
        Hand hand;
        DateTime dateTime;
        //
        dateTime = DateTime.Now;
        i = 0;
        n = list.Length;
        for(i=0;i<n;i++)
        {
            hand = list[i];
            hand.setHandRotation(dateTime);
        }
    }
}
