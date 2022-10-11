using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Karenscript : MonoBehaviour
{
    public TMP_Text Dialogue;
    public TMP_Text InputRequest;
    public int stage = 0;
    public Sprite home;
    public Sprite car;
    public Sprite dash;
    public Sprite blahaj;
    public Sprite road;
    public Sprite sign1;
    public Sprite sign2;
    public Sprite blockbuster;
    public Sprite aisle;
    public Sprite sharknado;
    public Sprite room;
    public Sprite jaws;
    public Sprite winner;
    public GameObject backg;
    public GameObject bblahaj;
    public GameObject boxart;
    SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        sr = backg.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        imput();
        
    }

    void imput()
    {
        if (Input.GetButtonDown("Continue")) { stage++; stagecheck(); } 
        if (Input.GetButtonDown("Yes")) { bbblahaj(true); stagecheck(); } 
        if (Input.GetButtonDown("No")) { bbblahaj(false); stagecheck(); } 
    }

    void dialog(string diulog)
    {
        Dialogue.SetText(diulog);
    }

    void stagecheck()
    {
        if (stage == 0) { dialog("AH WHAT A LOVELY MORNING"); }
        if (stage == 1) { dialog("TODAY I THINK I WILL WATCH SHARKNADO"); }
        if (stage == 2) { dialog("I SHOULD TAKE THE THANOS CAR"); sr.sprite = car; }
        if (stage == 3) { dialog("UH OH, NO GAS IN CAR SO WILL WALK TO BLOCKBUSTER"); backg.GetComponent<SpriteRenderer>().sprite = dash; }
        if (stage == 4) { dialog("DO YOU TAKE THE BLAHAJ???"); bblahaj.transform.position = new Vector3(0, 0, -1); }
    }

    void bbblahaj(bool yorn)
    {
        if (stage == 4)
        {
            if (yorn)
            {

            }
            else
            {

            }
        }
    }
}
