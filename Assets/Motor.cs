using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Motor : MonoBehaviour
{

    public Slider slider;

    public TMP_InputField inputField;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.rotation = Quaternion.Euler(0, slider.value, 0);
    }

    public void SetSliderValue()
    {
        float number;
        bool isNumeric = float.TryParse(inputField.text, out number);
        if (isNumeric)
        {
            slider.value = float.Parse(inputField.text);
        }
    }

}
