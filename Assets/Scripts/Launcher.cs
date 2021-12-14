using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class Launcher : MonoBehaviourPunCallbacks
{
    public InputField createInput;
    public InputField joinInput;
    public Text error;
 
    public void CreateRoom()
    {
        if (string.IsNullOrEmpty(createInput.text))
                return;
            PhotonNetwork.CreateRoom(createInput.text);
        Debug.Log("Room was Created");
    }

    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(joinInput.text);
        Debug.Log("Join Room");
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("RoomPanel");
    }

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        error.text = message;
        Debug.Log("Error creating room! " + message);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
