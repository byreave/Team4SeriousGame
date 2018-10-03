using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TestCanvas : MonoBehaviour {

    // Use this for initialization
    public Text X;
    public Text Y;
    public Text Z;
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        X.text = "X: " + Input.acceleration.x;
        Y.text = "Y: " + Input.acceleration.y;
        Z.text = "Z: " + Input.acceleration.z;
    }
}
