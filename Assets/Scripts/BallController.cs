using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

    private Rigidbody body;

	// Use this for initialization
	void Start () {
        body = GetComponent<Rigidbody>();
	}

    public void EnableGravity()
    {
        body.useGravity = true;
    }

    public void DisableGravity()
    {
        body.useGravity = false;
    }

    public void ResetPosition()
    {
        gameObject.transform.localPosition = Vector3.zero;
        body.velocity = Vector3.zero;
        body.angularVelocity = Vector3.zero;
    }
}
