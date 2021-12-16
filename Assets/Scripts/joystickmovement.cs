using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class joystickmovement : MonoBehaviour
{
    public Joystick joystick;
    public CharacterController player;
    Vector3 movementDirection;
    public float gravity = 15.0f;//Gravity intensity
    public float speed;
    public PhotonView view;

    // Update is called once per frame
    void Update()
    {
        if (view.IsMine)
        {

            float hori = joystick.Horizontal;
            float vert = joystick.Vertical;

            movementDirection = new Vector3(hori, 0, vert);
            movementDirection = transform.TransformDirection(movementDirection);

            movementDirection *= speed;

            movementDirection.y -= gravity;

            player.Move(movementDirection * Time.deltaTime);
        }


    }


}
