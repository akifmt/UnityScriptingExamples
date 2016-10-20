using UnityEngine;
using System.Collections;

public class WhileLoop : MonoBehaviour {

    int cupsInTheSink = 4;
	void Start ()
    {
	    while(0 < cupsInTheSink)
        {
            Debug.Log("I've washed a cup!");
            cupsInTheSink--;
        }
	}
}
