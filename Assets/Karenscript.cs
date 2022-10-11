using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Karenscript : MonoBehaviour
{
    public TMP_Text Dialogue;
    public TMP_Text directs;
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
    public GameObject prop1;
    public GameObject prop2;
    SpriteRenderer sr;
    Transform tf;
    bool choice = false;
    // Start is called before the first frame update
    void Start()
    {
        sr = backg.GetComponent<SpriteRenderer>();
        tf = backg.GetComponent<Transform>();
        stagecheck();
    }

    // Update is called once per frame
    void Update()
    {
        imput();      
    }

    void imput()
    {
        if (choice) 
        {
            if (Input.GetButtonDown("Yes"))
            {
                if (stage == 4) { bbblahaj(true); }
                if (stage == 10) { isnado(true); }
                if (stage == 8 || stage == 9) { isnado(false); }
                
            }
            else if (Input.GetButtonDown("No"))
            {
                if (stage == 4) { bbblahaj(false); }
                if (stage == 10) { isnado(false); }
                if (stage == 8 || stage == 9) { isnado(true); }
                
            }
            
            if (Input.GetButtonDown("left") && stage==5) { wherego(false); }
            else if (Input.GetButtonDown("right") && stage==5) { wherego(true); }

        }
        else { if (Input.GetButtonDown("Continue")) { stage++; stagecheck(); } }


    }

    void dialog(string diulog)
    {
        Dialogue.SetText(diulog);
    }
    void direct(string drec)
    {
        directs.SetText(drec);
    }
    void stagecheck()
    {
        if (stage == 0) { dialog("AH WHAT A LOVELY MORNING WITH MY GOOD FRIEND BLAHAJ"); tf.localScale = new Vector2(2, 1); }
        if (stage == 1) { dialog("TODAY I THINK I WILL WATCH SHARKNADO"); }
        if (stage == 2) { dialog("I SHOULD TAKE THE THANOS CAR"); sr.sprite = car; tf.localScale = new Vector2(2, 2); bblahaj.transform.position -= new Vector3(10, 0,0); }
        if (stage == 3) { dialog("UH OH, NO GAS IN CAR SO WILL WALK TO BLOCKBUSTER"); sr.sprite = dash; tf.localScale = new Vector2(4, 3); }
        if (stage == 4) { dialog("DO YOU BRING BLAHAJ???"); sr.sprite = blahaj; tf.localScale = new Vector2(3, 2); choice = true; direct("Press Y for Yes, and N for No"); }
        if (stage == 5) { dialog("HMM I DON’T REMBER WHICH WAY WAS BLOCKBUSTER AGAINS?"); sr.sprite = road; choice = true; direct("Press L for Left, or R for Right"); prop1.transform.position += new Vector3(100, 0, 0); prop2.transform.position += new Vector3(100, 0, -1); }
        if (stage == 6) { dialog("AH YES, BLUBSTER WAS RIGHT ALL ALONG"); sr.sprite = blockbuster; tf.localScale = new Vector2(3, 3); choice = false; direct("Press - Spacebar - To Continue"); prop1.transform.position -= new Vector3(100, 0, 0); prop2.transform.position -= new Vector3(100, 0, 1); }
        if (stage == 7) { dialog("ALL RIGHT LETS GET THAT SHARKNADO");sr.sprite = aisle; tf.localScale = new Vector2(2, 1.5f); }
        if (stage == 8) { dialog("IS THIS THE SHARKNADO????"); sr.sprite = room; tf.localScale = new Vector2(3, 1); direct("Press Y for Yes, and N for No"); choice = true; }
        if (stage == 9) { dialog("HOW ABOUT THIS ONE?"); sr.sprite = jaws; tf.localScale = new Vector2(6,2.3f); }
        if (stage == 10) { dialog("COULD THIS BE THE ONE??"); sr.sprite = sharknado; tf.localScale = new Vector2(.8f, .25f); }
        if (stage == 11) { dialog("WOW YOU THE WINNER, GO HOME AND WATCH SHARKNADO WITH BLAHAJ."); direct("Press - Spacebar - To Continue"); sr.sprite = winner; tf.localScale = new Vector2(7, 4); choice = false; }
        if(stage == 12) { dialog("VERY FUN TIME"); direct("THE END"); }
    }

    void bbblahaj(bool yorn)
    {
            if (yorn)
            {
              bblahaj.transform.position += new Vector3(10, 0,0);
              stage++;
              stagecheck();
        }
            else
            {
              stage++;
              stagecheck();
            }
        
    }

    void wherego(bool yorn)
    {
        if (yorn) 
        {
            stage++;
            stagecheck();
        }
        else 
        {
            dialog("HMM, THATS NOT QUITE RIGHT");
        }
    }
    void isnado(bool yorn)
    {
        if (yorn)
        {
            stage++;
            stagecheck();
        }
        else
        {
            dialog("HMM, THATS NOT QUITE RIGHT");
        }
    }
}
