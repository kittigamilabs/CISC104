using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneTilter : MonoBehaviour
{
    // Maximum tilt is in radians.
    // We can use this static value Mathf.Deg2Rad to convert a degree value to one in radians
    private float maximumXTilt = 10 * Mathf.Deg2Rad;
    private float maximumZTilt = 10 * Mathf.Deg2Rad;

    // Start is called before the first frame update
    void Start()
    {
        // This function could be removed as nothing special happens here currently.
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            if (gameObject.transform.rotation.x < maximumXTilt)
            {
                gameObject.transform.Rotate(.1f, 0, 0);
            }
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            // Implement a behavior to make the left arrow rotate the plane in the opposite direction of the left arrow
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // Implement a behavior to make the left arrow rotate the plane in the opposite direction of the right arrow
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (gameObject.transform.rotation.z > -maximumZTilt)
            {
                gameObject.transform.Rotate(0, 0, -.1f);
            }
        }
    }
}
