using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CubeDefault : MonoBehaviour
{
    private Rigidbody cubeRb;
    private GameObject player;
    public int force;

    public virtual void Start()
    {
        cubeRb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
        force = 1;
        CubeTransform();
    }

    private void Update()
    {
        CubeMovement();
    }

    public virtual void CubeMovement()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        cubeRb.AddForce(lookDirection * force);
    }

    public virtual void CubeTransform()
    {
        transform.localScale = new Vector3(1, 1, 1);
    }
}
