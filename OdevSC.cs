using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OdevSC : MonoBehaviour
{

    public AudioSource audioSource;
    public Rigidbody rb1;
    public BoxCollider boxColl;
    public sc1Script sc1;
    public sc2Script sc2;

    public CapsuleCollider capsuleColl;
    public Rigidbody rb2;
    public Rigidbody rb3;
    public SphereCollider sphereColl;
    public sc3Script sc3;

    public Text text;
    public Button buton;
    public InputField inputfield;
    public GameObject panel;
    public Toggle toggle;

    void Start()
    {
        audioSource = GameObject.FindWithTag("AudioSource").GetComponent<AudioSource>();
        rb1 = GameObject.FindWithTag("Rigid1").GetComponent<Rigidbody>();
        boxColl = GameObject.FindWithTag("BoxColl").GetComponent<BoxCollider>();
        sc1 = GameObject.FindWithTag("SC1").GetComponent<sc1Script>();
        sc2 = GameObject.FindWithTag("SC2").GetComponent<sc2Script>();

        capsuleColl = GameObject.Find("CapsuleColl").GetComponent<CapsuleCollider>();
        rb2 = GameObject.Find("Rigid2").GetComponent<Rigidbody>();
        rb3 = GameObject.Find("Rigid3").GetComponent<Rigidbody>();
        sphereColl = GameObject.Find("SphereColl").GetComponent<SphereCollider>();
        sc3 = GameObject.Find("Script3").GetComponent<sc3Script>();

        text = GameObject.Find("text1").GetComponent<Text>();
        buton = GameObject.Find("buton1").GetComponent<Button>();
        inputfield = GameObject.Find("inputfield").GetComponent<InputField>();
        panel = GameObject.Find("abcPanel");
        toggle = GameObject.Find("Toggle").GetComponent<Toggle>();

        //
        audioSource.mute = true;
        rb1.mass = 0.5f;
        boxColl.isTrigger = true;
        sc1.transform.position = new Vector2 (0,3);
        sc2.name = "degisIsim";

        capsuleColl.center = new Vector2 (0,5);
        rb2.drag = 0.4f;
        rb3.useGravity = false;
        sphereColl.radius = 0.3f;
        sc3.tag = "denemeTag";

        text.text = "Merhaba";
        buton.image.color = Color.blue;
        inputfield.textComponent.fontSize = 55;
        panel.SetActive(false);
        toggle.isOn = false;
    }
}