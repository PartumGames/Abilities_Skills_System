using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bar : MonoBehaviour
{
    private Slider slider;

    private Image background;
    private Image sliderImage;
    private Text sliderText;

    [SerializeField]
    private float value = 0f;

    [SerializeField]
    private float maxValue = 100f;

    [SerializeField]
    private string textValue = "";

    public Color barColor;
    public Color backgroundColor;

    private void Start()
    {
        slider = GetComponent<Slider>();
        background = transform.GetChild(0).GetComponent<Image>();
        sliderImage = transform.GetChild(1).GetComponentInChildren<Image>();
        sliderText = transform.GetChild(3).GetComponent<Text>();
        UpdateUI();
    }


    public void SetValue(float _value)
    {
        value = _value;
        UpdateUI();
    }

    public void SetMaxValue(float _maxValue)
    {
        maxValue = _maxValue;
        UpdateUI();
    }

    public void SetBarColor(Color _color)
    {
        barColor = _color;
        UpdateUI();
    }

    public void SetBackgroundColor(Color _color)
    {
        backgroundColor = _color;
        UpdateUI();
    }

    public void SetTextValue(string _value)
    {
        textValue = _value;
        UpdateUI();
    }



    private void UpdateUI()
    {
        value = Mathf.Clamp(value, 0, maxValue);

        slider.maxValue = maxValue;
        slider.value = value;

        sliderText.text = textValue + " : " + value.ToString() + " / " + maxValue.ToString();

        background.color = backgroundColor;
        sliderImage.color = barColor;
    }

}
