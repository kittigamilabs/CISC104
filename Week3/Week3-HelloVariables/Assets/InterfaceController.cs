using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InterfaceController : MonoBehaviour
{
    public GameObject value1GameObject;
    public GameObject value2GameObject;

    TextMeshPro value1Text;
    TextMeshPro value2Text;

    private int value1;
    private int value2;

    // Start is called before the first frame update
    void Start()
    {
        value1Text = value1GameObject.GetComponent<TextMeshPro>();
        value2Text = value2GameObject.GetComponent<TextMeshPro>();

        value1 = 0;
        value2 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        value1Text.text = value1.ToString();
        value2Text.text = value2.ToString();
    }

    public void MyButton1()
    {
        value1 += 100;
    }

    public void MyButton2()
    {
        value2 = value1 + 50;
    }

    public void MyButton3()
    {
        value2 /= 3;
    }

    public void YourButton1()
    {
        // Add your first button behavior here
    }

    public void YourButton2()
    {
        // Add your second button behavior here
    }

    public void YourButton3()
    {
        // Add your third button behavior here
    }
}
