using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddConstantVelocity : MonoBehaviour
{

	[SerializeField]
	Vector3 v3Force;

    // Update is called once per frame
    void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity=v3Force;
    }
}
