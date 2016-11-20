using UnityEngine;
using System.Collections;

public class LinearInterpolation : MonoBehaviour {

    [SerializeField]
    Light light;
    
    void Start ()
    {
        float result = Mathf.Lerp(3f, 5f, 0.5f);
        Debug.Log("result: " + result);
        //result = 4

        Vector3 from = new Vector3(1f, 2f, 3f);
        Vector3 to = new Vector3(5f, 6f, 7f);
        Vector3 result2 = Vector3.Lerp(from, to, 0.75f);
        Debug.Log("result2: "+ result2);
        //result2 = (4,5,6)

        
    }
    
    void Update ()
    {
        light.intensity = Mathf.Lerp(light.intensity, 8f, 0.5f * Time.deltaTime);
	}
}
