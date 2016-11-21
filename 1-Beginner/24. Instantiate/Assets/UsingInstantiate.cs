using UnityEngine;
using System.Collections;

public class UsingInstantiate : MonoBehaviour {

    public Rigidbody rocketPrefab;
    public Transform barrelEnd;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody rocketInstantiate;
            rocketInstantiate = Instantiate(rocketPrefab, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
            rocketInstantiate.AddForce(barrelEnd.forward * 5000);
        }
    }
}
