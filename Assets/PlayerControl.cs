using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerControl : MonoBehaviour
{

    // Use this for initialization
    public GameObject slider;
    private Vector3 vector;
    void Start()
    {
        vector = new Vector3(0.01f, 0.01f, 0.0f);
        slider.GetComponent<Slider>().onValueChanged.AddListener(onSliderBarChanged);
        //slider = GameObject.Find("Silder");
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.Translate(vector);

    }


    public void onSliderBarChanged(float value)
    {
        vector.x = value;
        this.GetComponent<Rigidbody2D>().gravityScale = value;
    }
}
