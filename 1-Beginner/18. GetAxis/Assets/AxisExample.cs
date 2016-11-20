using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AxisExample : MonoBehaviour {
    public float range;
    public Text textOutput;
    
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float xPos = h * range;

        transform.position = new Vector3(xPos, 2f, 0);
        textOutput.text = "AxisExample Value Returned: " + h.ToString("F2");
    }
}
