//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;
//using Phonton.Pun;

//public class Launcher : MonoBehaviour
//{
//    public InputField createInput;
//    public InputField joinInput;

//    // Start is called before the first frame update
//    void Start()
//    {
//        Debug.Log("Connecting");
//        PhotonNetwork.ConnectUsingSettings();
//    }

//    public override void OnConnectedToMaster()
//    {
//        Debug.Log("Connected");
//        PhotonNetwork.JoinLobby();
//    }

//    public override void OnJoinedLobby()
//    {
//        Debug.Log("Joined Main Lobby");
//    }

//    public void CreateRoom()
//    {
//        if (string.IsNullOrEmpty(createInput.text))
//            return;
//        PhotonNetwork.CreateRoom(createInput.text);
//    }

//    public void JoinRoom()
//    {
//        PhontonNetwork.JoinRoom(joinInput.text);
//    }

//    public override void OnJoinedRoom()
//    {

//    }

//    public override void OnCreateRoomFailed(short returnCode, string message)
//    {
//        Debug.Log("Error creating room!");
//    }

//    // Update is called once per frame
//    void Update()
//    {

//    }
//}
