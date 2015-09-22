using UnityEngine;
using System.Collections;


public class BridgeMove : MonoBehaviour {

//	public GameObject bridge;
//	Vector3 bridgePosition;
	// Use this for initialization

	public float min=2f;
	public float max=4f;
//
	void Start()
	{
		min= transform.position.y;
		max= transform.position.y+3;
//		transform.Translate(Vector3.up * Time.deltaTime , transform);
	}

	// Update is called once per frame
	void Update () 
	{

		transform.position =new Vector3(transform.position.x,
		                                Mathf.PingPong(Time.time*2, max-min )+ min, transform.position.z);

//		if(
//		transform.Translate(Vector3.up * Time.deltaTime , transform);

//		bridgePosition = transform.position;
//		ConstantForce ConsForce = GetComponent<ConstantForce>();

//		ConsForce.force.Set(0,100,0);
//		if(bridgePosition.y <= 7.5)
//		{
//			ConsForce.force.Set(0,4,0);
//		}
//
//		if(bridgePosition.y >= 20)
//		{
//			ConsForce.force.Set (0,-4,0);
//		}

	}

}