using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerControl : MonoBehaviour
{

    // Use this for initialization
    public Slider gravSlider;
    public Slider massSlider;

    public Canvas canvas;
    public Canvas resCanvas;

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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        canvas.gameObject.SetActive(false);
        resCanvas.gameObject.SetActive(true);

    }
}
