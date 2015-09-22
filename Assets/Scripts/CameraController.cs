using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour 
{

	[SerializeField]
	private float distanceAway;
	[SerializeField]
	private float distanceUp;
	[SerializeField]
	private float smooth;
	[SerializeField]
	private Vector3 CameraPosition;
	
	public GameObject player;
	private Transform playerTransform;
	

	//	private Vector3 offset;
	
	// Use this for initialization
	void Start () 
	{
		//		offset = transform.position - player.transform.position;
		
		playerTransform = player.transform;
		
	}
	
	void Update()
	{
		
	}
	
	void OnDrawGizmo()
	{
		
	}
	
	// Update is called once per frame
	void LateUpdate ()
	{

		//		transform.position = player.transform.position + offset;
	
		//setting the camera position to be the correct offset from the hovercraft
		CameraPosition = playerTransform.position + Vector3.up * distanceUp - playerTransform.forward * distanceAway;
		
		//making a smooth transition between its current position and the position it want to be in
		transform.position = Vector3.Lerp(transform.position, CameraPosition, Time.deltaTime *smooth);


		//make sure the camera is looking the right way!
		transform.LookAt (playerTransform);


	}

}
