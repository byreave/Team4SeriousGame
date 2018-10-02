using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FadeScript : MonoBehaviour
{
    public float alfa;
    float speed = 0.005f;
    float red, green, blue;

    public bool fin,fout; 

    void Start()
    {
        red = GetComponent<Image>().color.r;
        green = GetComponent<Image>().color.g;
        blue = GetComponent<Image>().color.b;

        if (fin)
        {
            alfa = 1;
        }
        if (fout)
        {
            alfa = 0;
        }
        fin = true;
    }

    void Update()
    {
        GetComponent<Image>().color = new Color(red, green, blue, alfa);

        if (fin)
        {
            alfa -= speed;
        }
        if (fout)
        {
            alfa += speed;
        }
    }

}