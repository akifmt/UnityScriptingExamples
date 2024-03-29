﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DualAxisExample : MonoBehaviour {

    public float range;
    public Text textOutput;


    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float xPos = h * range;
        float yPos = v * range;

        transform.position = new Vector3(xPos, yPos, 0);
        textOutput.text = "DualAxisExample Horizontal Value Returned: " + h.ToString("F2") + "\n DualAxisExample Vertical Value Returned: " + v.ToString("F2");
    }
}
