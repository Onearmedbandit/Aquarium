using UnityEngine;
using System.Collections;

public class FishPhysics : MonoBehaviour {
	public Vector3 destination = new Vector3(100f,100f,0f);
	public float speed = 5f;
	// Use this for initialization
	void Start () {
	
		InvokeRepeating("SetNewDestination", 0f, 15f);
	}
	
	// Update is called once per frame
	void Update () {
		transform.rotation = Quaternion.LookRotation (rigidbody.velocity);
	
	}
	void FixedUpdate() {
        
		//rigidbody.AddForce(Vector3.up,ForceMode.Impulse);
		Vector3 direction = Vector3.Normalize (destination - transform.position);
		rigidbody.AddForce (direction * speed, ForceMode.VelocityChange);
    }
	void SetNewDestination() {
		destination = Random.insideUnitSphere * 100f;
		speed = Random.value + Random.value + 1f;
	}
}
