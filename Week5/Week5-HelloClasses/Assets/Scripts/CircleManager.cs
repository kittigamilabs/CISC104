using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CircleManager : MonoBehaviour
{
    public Slider radiusSlider;
    private float circumference;
    private float area;

    public GameObject radiusTextObject;
    public GameObject circumferenceTextObject;
    public GameObject areaTextObject;

    private TextMeshProUGUI radiusText { get; set; }
    private TextMeshProUGUI circumferenceText { get; set; }
    private TextMeshProUGUI areaText { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        radiusText = radiusTextObject.GetComponent<TextMeshProUGUI>();
        circumferenceText = circumferenceTextObject.GetComponent<TextMeshProUGUI>();
        areaText = areaTextObject.GetComponent<TextMeshProUGUI>();

        CalculateGeometricProperties();
    }

    // Update is called once per frame
    void Update()
    {
        radiusText.text = "Circle Radius: " + radiusSlider.value.ToString();
        circumferenceText.text = "Circle Circumference: " + circumference.ToString();
        areaText.text = "Circle Area: " + area.ToString();
    }

    public void SliderChanged(float newValue)
    {
        CalculateGeometricProperties();
    }

    private void CalculateGeometricProperties()
    {
        circumference = 2 * Mathf.PI * radiusSlider.value;
        area = Mathf.PI * (radiusSlider.value * radiusSlider.value);
    }
}
