using System;
using UnityEngine;

public class BlueBallCollisionManager : BallCollisionManager
{
    public GameObject greenBallPrefab;
    public GameObject plane;

    public override void CollideWithBall(GameObject OtherBall)
    {
        Debug.Log("Blue Ball Collision Manager Function");

        if(OtherBall.GetComponent<YellowBallCollisionManager>() != null)
        {
            Debug.Log("Blue Collided With Yellow");

            // Since the blue ball collided with the yellow ball, we will make a green one.
            Instantiate(greenBallPrefab, plane.transform);
        }
    }
}

