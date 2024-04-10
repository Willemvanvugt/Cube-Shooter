using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class CubeDefault : MonoBehaviour
{
    private Rigidbody cubeRb;
    private GameObject player;
    public float force;

    public int pointValue;

    public GameObject cube;
    public string cubeName;

    private GameManager gameManager;

    private GameMenu gameMenu;

    public virtual void Start()
    {
        force = 0.2f;
        cubeRb = GetComponent<Rigidbody>();

        player = GameObject.FindGameObjectWithTag("Player");

        cubeName = cube.name;

        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        pointValue = 2;

        gameMenu = GameObject.Find("Canvas - Game").GetComponent<GameMenu> ();

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
        gameManager.UpdateScore(pointValue);
        Debug.Log("Score was increased by " + pointValue);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log(cubeName + " collided with player.");
            Destroy(gameObject);
            gameMenu.GameOver();
        }
    }

}
