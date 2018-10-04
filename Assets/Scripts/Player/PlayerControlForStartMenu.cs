using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerControlForStartMenu : MonoBehaviour
{
    //Material definition
    public struct Material
    {
        public float mass; //since we don't change volume of our object, mass = density
        public string name;
        public PhysicsMaterial2D material;
        public Sprite sprite;
        public bool isMagnetic;
        public Material(float m, PhysicsMaterial2D mat, bool isM, Sprite s, string n) { mass = m; material = mat; isMagnetic = isM; sprite = s; name = n; }
    }
    //for paricle systems
    public GameObject player;
    public ParticleSystem Ping;

    // Use this for initialization
    //public Slider gravSlider;
    //public Slider massSlider;

    public Canvas canvas;
    //public Canvas canvasStateR;
    //public Canvas canvasStateI;
    public Canvas resCanvas;
    public GameObject endgame;

    public PhysicsMaterial2D ironMat;
    public PhysicsMaterial2D rubberMat;
    public PhysicsMaterial2D glassMat;
    public Vector3 force;

    public bool toLeft = false; //move by button
    public bool toRight = false; //move by button

    


    //sprite image
    [SerializeField]
    private Sprite RubberSprite;
    [SerializeField]
    private Sprite IronSprite;
    [SerializeField]
    private Sprite GlassSprite;
    [SerializeField]
    private float SpeedLimit = 2.0f;

    public Sprite Indicator;
    public Sprite rubberI;
    public Sprite IronI;

    //Material
    List<Material> Materials;
    Material Iron;
    Material Rubber;
    Material Glass;
    public Material currentMat;
    Material IronIn;
    Material RubberIn;

    //Magnetic
    public bool isMagnetic;

    //Material Index
    private int ind = 0;
    

    void Start()
    {
        Materials = new List<Material>();

        //create / add materials here
        Iron = new Material(5.0f, ironMat, true, IronSprite, "Iron");
        Rubber = new Material(0.5f, rubberMat, false, RubberSprite, "Rubber");
        Glass = new Material(2.0f, glassMat, false, GlassSprite, "Glass");
        IronIn = new Material(5.0f, ironMat, true, IronI, "IronI");
        RubberIn = new Material(0.5f, rubberMat, false, rubberI, "RubberI");
        Materials.Add(Iron);
        Materials.Add(Rubber);
        isMagnetic = false;
        //canvasStateI.gameObject.SetActive(true);

        switchMaterial(Iron);
        ind = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //if (toLeft)
        //{
        //    this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-force * Time.deltaTime, 0));
        //}
        //else if (toRight)
        //{
        //    this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(force * Time.deltaTime, 0));
        //}
        //else
        //    this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 0));
        if (Mathf.Abs(this.GetComponent<Rigidbody2D>().velocity.x) <= SpeedLimit)
            this.GetComponent<Rigidbody2D>().AddForce(Input.acceleration.x * force);
        else if (this.GetComponent<Rigidbody2D>().velocity.x >= SpeedLimit && Input.acceleration.x < 0)
            this.GetComponent<Rigidbody2D>().AddForce(Input.acceleration.x * force);
        else if (this.GetComponent<Rigidbody2D>().velocity.x <= -SpeedLimit && Input.acceleration.x > 0)
            this.GetComponent<Rigidbody2D>().AddForce(Input.acceleration.x * force);
        //this.transform.Translate(vector);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
    }

    private void applyFlotation(Collider2D collision)
    {
        this.GetComponent<Rigidbody2D>().AddForce(collision.gameObject.GetComponent<WatertileControl>().getCurrentFlotation(this.transform.position, this.GetComponent<CircleCollider2D>().radius));

    }

    public void changeMode()
    {
        ind++;
        if (ind >= Materials.Count)
            ind = 0;
        switchMaterial(Materials[ind]);
    }

    public void switchMaterial(Material m)
    {
        //actually make changes
        this.GetComponent<Rigidbody2D>().mass = m.mass;
        this.GetComponent<CircleCollider2D>().sharedMaterial = m.material;
        isMagnetic = m.isMagnetic;
        currentMat = m;
        this.GetComponent<SpriteRenderer>().sprite = m.sprite;
        //Instantiate(Ping, player.transform.localPosition, Quaternion.identity, player.transform);
    }
}
