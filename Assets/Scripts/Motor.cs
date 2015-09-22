using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class Motor : MonoBehaviour {
	
	public Transform centerOfMass;
	public float spConstant = 40000f;
	public float tspConstant = 1000f;

	public Wheel[] wheel;

	Rigidbody rbody;

	void Awake()
	{
		rbody = GetComponent<Rigidbody>();
	}

	void Start()
	{
		rbody.centerOfMass = centerOfMass.localPosition;
	}


	void FixedUpdate() 
	{
		float torque = Input.GetAxis ("Vertical") * spConstant;
		float turnSpeed = Input.GetAxis ("Horizontal") * tspConstant;


		if(torque != 0)
		{
			//front wheel drive
	//		wheel[0].Move(torque);
	//		wheel[1].Move (torque);

			//rear wheel drive
			wheel[2].Move(torque);
			wheel[3].Move (torque);

		}
		//front wheel steering
		wheel[0].Turn(turnSpeed);
		wheel[1].Turn(turnSpeed);

		//rear wheel steering
//		wheel[2].Turn(turnSpeed);
//		wheel[3].Turn(turnSpeed);
		

	}
	
}
