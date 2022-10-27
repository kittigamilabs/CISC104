using System;
using UnityEngine;

public class YellowBallCollisionManager : BallCollisionManager
{
    public override void CollideWithBall(GameObject OtherBall)
    {
        Debug.Log("Yellow Ball Collision Manager Function");

        if (OtherBall.GetComponent<BlueBallCollisionManager>() != null)
        {
            Debug.Log("Yellow Collided With Blue");

            // I'm not going to do something here because I am doing something in the BlueBallCollisionManager
            // Since both are triggered, I chose to only process the event from one object.
        }
    }
}

