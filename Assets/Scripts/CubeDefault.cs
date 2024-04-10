using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CubeDefault : MonoBehaviour
{
    private Rigidbody cubeRb;
    private GameObject player;
    public int force;
    public int pointValue;
    public GameObject cube;
    public string cubeName;

    public virtual void Start()
    {
        cubeName = cube.name;
        cubeRb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
        force = 1;
        pointValue = 2;
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

    private void OnMouseDown()
    {
        Destroy(gameObject);
        Debug.Log(cubeName + " was destroyed.");
    }
}
