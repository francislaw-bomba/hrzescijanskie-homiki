using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private GameObject Cam;
    [SerializeField] public int RoomPlayerIsIn = 1;
    public void GoToRoomOne()
    {
        Cam.transform.position = new Vector3(0, 0, -10);
        RoomPlayerIsIn = 1;
    }
    public void GoToRoomTwo()
    {
        Cam.transform.position = new Vector3(0, 10, -10);
        RoomPlayerIsIn = 2;
    }
    public void GoToRoomThree()
    {
        Cam.transform.position = new Vector3(21.3f, 0, -10);
        RoomPlayerIsIn = 3;
    }
}
