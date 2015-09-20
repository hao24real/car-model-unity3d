using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class Motor : MonoBehaviour {
	
	public Wheel[] wheel;

	public float spConstant;
	public float tspConstant;

	void FixedUpdate() 
	{
		float torque = Input.GetAxis ("Vertical") * spConstant;
		float turnSpeed = Input.GetAxis ("Horizontal") * tspConstant;

		//front wheel drive
		wheel[0].Move(torque);
		wheel[1].Move (torque);

		//rear wheel drive
//		wheel[2].Move(torque);
//		wheel[3].Move (torque);


		//front wheel steering
		wheel[0].Turn(turnSpeed);
		wheel[1].Turn(turnSpeed);

		//rear wheel steering
//		wheel[2].Turn(turnSpeed);
//		wheel[3].Turn(turnSpeed);

	}
	
}
