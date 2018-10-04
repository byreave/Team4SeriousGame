using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GravityTextControl : MonoBehaviour {

    // Use this for initialization
    public Text minText;
    public Text maxText;
    public Text curText;

    private float GravitationalConstant = - Physics.gravity.y;
    private Slider slider;
    void Start()
    {
        slider = this.GetComponentInParent<Slider>();
        minText.text = ( GravitationalConstant * slider.minValue ).ToString();
        maxText.text = ( GravitationalConstant * slider.maxValue ).ToString();
        curText.text = ( GravitationalConstant * slider.value ).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        curText.text = ( GravitationalConstant * slider.value ).ToString();
    }
}
