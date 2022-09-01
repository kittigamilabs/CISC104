using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextAssignmentComponent : MonoBehaviour
{
    public GameObject nameTextGameObject;
    public GameObject udidTextGameObject;

    // Start is called before the first frame update
    void Start()
    {
        TextMeshPro nameText = nameTextGameObject.GetComponent<TextMeshPro>();
        TextMeshPro udidText = udidTextGameObject.GetComponent<TextMeshPro>();

        nameText.text = "Fill in your name";
        udidText.text = SystemInfo.deviceUniqueIdentifier;
    }

    // Update is called once per frame
    void Update()
    {
        // Nothing happens here...yet.
    }
}
