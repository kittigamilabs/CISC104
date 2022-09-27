using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RectangleManager : MonoBehaviour
{
    private Rectangle myRectangle;

    public Slider heightSlider;
    public Slider widthSlider;

    public GameObject heightTextObject;
    public GameObject widthTextObject;
    public GameObject perimeterTextObject;
    public GameObject areaTextObject;

    private TextMeshProUGUI heightText { get; set; }
    private TextMeshProUGUI widthText { get; set; }
    private TextMeshProUGUI perimeterText { get; set; }
    private TextMeshProUGUI areaText { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        heightText = heightTextObject.GetComponent<TextMeshProUGUI>();
        widthText = widthTextObject.GetComponent<TextMeshProUGUI>();
        perimeterText = perimeterTextObject.GetComponent<TextMeshProUGUI>();
        areaText = areaTextObject.GetComponent<TextMeshProUGUI>();

        // Calls basic constructor, but sets height and width to 0
        myRectangle = new Rectangle();

        GetValuesFromSliders();
    }

    // Update is called once per frame
    void Update()
    {
        heightText.text = "Rectangle Height: " + myRectangle.GetHeight().ToString();
        widthText.text = "Rectangle Width: " + myRectangle.GetWidth().ToString();
        perimeterText.text = "Rectangle Perimeter: " + myRectangle.GetPerimeter().ToString();
        areaText.text = "Rectangle Area: " + myRectangle.GetArea().ToString();
    }

    public void SliderChanged(float newValue)
    {
        GetValuesFromSliders();
    }

    private void GetValuesFromSliders()
    {
        myRectangle.SetHeight(heightSlider.value);
        myRectangle.SetWidth(widthSlider.value);
    }
}
