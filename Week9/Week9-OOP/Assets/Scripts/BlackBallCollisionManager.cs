using System;
using UnityEngine;

public class BlackBallCollisionManager : BallCollisionManager
{
    public override void CollideWithBall(GameObject OtherBall)
    {
        Debug.Log("Black Ball Collision Manager Function");

        // Black ball destroys other balls.
        Destroy(OtherBall);
    }
}

