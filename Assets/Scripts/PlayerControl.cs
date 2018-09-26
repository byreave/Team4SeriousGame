using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerControl : MonoBehaviour
{

    // Use this for initialization
    public Slider gravSlider;
    public Slider massSlider;

    void Start()
    {
        gravSlider.onValueChanged.AddListener(onGravSliderBarChanged);
        massSlider.onValueChanged.AddListener(onMassSliderBarChanged);
        this.GetComponent<Rigidbody2D>().gravityScale = gravSlider.value;
        this.GetComponent<Rigidbody2D>().mass = massSlider.value;

    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.Translate(vector);

    }


    public void onGravSliderBarChanged(float value)
    {
        this.GetComponent<Rigidbody2D>().gravityScale = value;
    }
    public void onMassSliderBarChanged(float value)
    {
        this.GetComponent<Rigidbody2D>().mass = value;
    }
}
