using UnityEngine;
using System.Collections;

public class MouseClick : MonoBehaviour {

    public Rigidbody rigidbody;

    void OnMouseDown()
    {
        rigidbody.AddForce(transform.forward * 500f);
        rigidbody.useGravity = true;
    }
}
