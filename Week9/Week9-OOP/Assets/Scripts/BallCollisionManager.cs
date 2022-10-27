using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BallCollisionManager : MonoBehaviour
{
    static int ballCollisionCount = 0;
    static int wallCollisionCount = 0;

    private TextMeshPro ballCountText;
    private TextMeshPro wallCountText;

    // Start is called before the first frame update
    void Start()
    {
        GameObject ballCountGameObject = GameObject.Find("BallCollisionCount");
        GameObject wallCountGameObject = GameObject.Find("WallCollisionCount");

        ballCountText = ballCountGameObject.GetComponent<TextMeshPro>();
        wallCountText = wallCountGameObject.GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        ballCountText.text = "Ball Collision Count: " + ballCollisionCount;
        wallCountText.text = "Wall Collision Count: " + wallCollisionCount;
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ball")
        {
            ballCollisionCount++;

            // Added function to collide with Ball
            // If this base component is attached to an object, then the virtual function here will be called.
            // If one of the inherited components is attached to an object, its function override will be called.
            CollideWithBall(collision.gameObject);
        }

        if (collision.gameObject.tag == "Wall")
        {
            wallCollisionCount++;
        }
    }

    public virtual void CollideWithBall(GameObject OtherBall)
    {
        Debug.Log("Base Collision Manager Function");
    }
}
