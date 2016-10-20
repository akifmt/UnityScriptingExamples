using UnityEngine;
using System.Collections;

public class UpdateAndFixedUpdate : MonoBehaviour {
    
    void FixedUpdate()
    {
        Debug.Log("Fixed Update time: "+Time.deltaTime);
    }

	void Update ()
    {
        Debug.Log("Update time: "+Time.deltaTime);
	}
}
