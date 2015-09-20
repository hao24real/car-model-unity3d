using UnityEngine;
using System.Collections;


[RequireComponent(typeof(WheelCollider))]
public class Wheel : MonoBehaviour 
{

	[SerializeField]Transform tire;
	WheelCollider wc;

	void Awake()
	{
		wc = GetComponent<WheelCollider>();

	}

	public void Move(float value)
	{
		wc.motorTorque = value;

	}

	public void Turn(float value)
	{
		wc.steerAngle = value;
		tire.localEulerAngles = new Vector3(0f, wc.steerAngle , 90f);
	}
}