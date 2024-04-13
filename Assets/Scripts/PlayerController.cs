using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private Vector2 turn;
    public float mouseSensitivity;

    private void Start()
    {
        mouseSensitivity = 2.5f;
        Debug.Log("Mouse senstivity set to " + mouseSensitivity);
    }

    private void Update()
    {
        turn.x += Input.GetAxis("Mouse X") * mouseSensitivity;
        turn.y += Input.GetAxis("Mouse Y") * mouseSensitivity;
        transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);
    }
}
