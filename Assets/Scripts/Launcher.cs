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

    //string errorInfo = "Error!";
 
    public void CreateRoom()
    {
        if (string.IsNullOrEmpty(createInput.text))
                return;
            PhotonNetwork.CreateRoom(createInput.text);
    }

    //    public void JoinRoom()
    //    {
    //        PhontonNetwork.JoinRoom(joinInput.text);
    //    }

    public override void OnJoinedRoom()
    {
        
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
