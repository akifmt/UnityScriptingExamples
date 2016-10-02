using UnityEngine;
using System.Collections;

public class IfStatements : MonoBehaviour {

    float coffeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;

	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TemperatureTest();
        }
        coffeTemperature -= Time.deltaTime * 5f;
	}
    void TemperatureTest()
    {
        // If the coffe's temperature is greater than the hottest drinking temperature...
        if (coffeTemperature > hotLimitTemperature)
        {
            // .. do this.
            print("coffe is too hot.");
        }
        // If it isn't, but the coffe temperature is less then the coldest drinking temperature...
        else if (coffeTemperature < coldLimitTemperature)
        {
            // .. do this.
            print("coffe is too cold.");
        }
        // If it is neither of those then...
        else
        {
            // .. do this.
            print("Coffe is just right.");
        }
    }
}
