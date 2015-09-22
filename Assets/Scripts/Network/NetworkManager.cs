using UnityEngine;
using System.Collections;

public class NetworkManager : MonoBehaviour {


	const string VERSION = "v0.0.1";
	public string roomName = "ahkbar";
//	public string carPrefabName= "Car";


//	public GameObject camera1;

//	public string cameraPrefabName= "Main Camera";
	public string playerPrefabName= "Player";
	public Transform spawnPoint;
//
//	void Awake()
//	{
//		camera1 = GameObject.FindWithTag("Camera 1");
//	}

	void Start () 
	{

		PhotonNetwork.ConnectUsingSettings(VERSION);

	}


	void OnJoinedLobby()
	{
		RoomOptions roomOptions = new RoomOptions() { isVisible = false, maxPlayers = 4 };
		PhotonNetwork.JoinOrCreateRoom(roomName, roomOptions, TypedLobby.Default);
	}


	void OnJoinedRoom()
	{
		PhotonNetwork.Instantiate(playerPrefabName, spawnPoint.position, spawnPoint.rotation, 0);
//		PhotonNetwork.Instantiate(carPrefabName, spawnPoint.position, spawnPoint.rotation, 0);


//		PhotonNetwork.Instantiate(cameraPrefabName, spawnPoint.position, spawnPoint.rotation, 0);
	}
}
