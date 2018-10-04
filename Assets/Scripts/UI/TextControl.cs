using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextControl : MonoBehaviour {

    // Use this for initialization
    public Text minText;
    public Text maxText;
    public Text curText;

    private Slider slider;
    void Start () {
        slider = this.GetComponentInParent<Slider>();
        minText.text = slider.minValue.ToString();
        maxText.text = slider.maxValue.ToString();
        curText.text = slider.value.ToString();
    }
	
	// Update is called once per frame
	void Update () {
        curText.text = slider.value.ToString();
    }
}
