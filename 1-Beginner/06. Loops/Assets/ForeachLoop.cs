using UnityEngine;
using System.Collections;

public class ForeachLoop : MonoBehaviour {

	void Start ()
    {
        string[] strings = new string[3];

        strings[0] = "first string";
        strings[1] = "second string";
        strings[2] = "third string";

        foreach (string item in strings)
        {
            print(item);
        }
	
	}
}
