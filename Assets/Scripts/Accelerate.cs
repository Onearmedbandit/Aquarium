using UnityEngine;
using System.Collections;

public class Accelerate : MonoBehaviour {
    void FixedUpdate() {
        rigidbody.AddForce(Vector3.down * 2,ForceMode.Impulse);
    }
}