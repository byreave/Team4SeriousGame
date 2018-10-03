using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlashText : MonoBehaviour {

    public float speed = 1.0f;

    private Text text;
    private Image image;
    private float time;

    private enum ObjType
    {
        TEXT,
        IMAGE
    };

    private ObjType thisObjType;

	// Use this for initialization
	void Start () {
        if (this.gameObject.GetComponent<Image>())
        {
            thisObjType = ObjType.IMAGE;
            image = this.gameObject.GetComponent<Image>();
        }
        else if (this.gameObject.GetComponent<Text>())
        {
            thisObjType = ObjType.TEXT;
            text = this.gameObject.GetComponent<Text>();
        }
    }
	
	// Update is called once per frame
	void Update () {
		if(thisObjType == ObjType.IMAGE)
        {
            image.color = GetAlphaColor(image.color);
        } else if (thisObjType == ObjType.TEXT)
        {
            text.color = GetAlphaColor(text.color);
        }
    }

    private Color GetAlphaColor(Color color)
    {
        time += Time.deltaTime * 5.0f * speed;
        color.a = (float)(Mathf.Sin(time) * 0.5f + 0.5);

        return color;
    }
}
