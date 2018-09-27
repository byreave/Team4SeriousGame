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
    public GameObject endgame;

    public float force = 0.05f;

    public bool toLeft = false;
    public bool toRight = false;
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



        if (toLeft)
        {
            this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-force * Time.deltaTime, 0));
        }
        else if (toRight)
        {
            this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(force * Time.deltaTime, 0));
        }
        else
            this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 0));

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
        //canvas.gameObject.SetActive(false);
       // resCanvas.gameObject.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.Equals(endgame))
        {
            //Debug.Log("it worked");
            canvas.gameObject.SetActive(false);
            resCanvas.gameObject.SetActive(true);
        }

        if (collision.gameObject.CompareTag("Collectable"))
        {
            collision.gameObject.SetActive(false);
        }
    }
}
