using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class trigger2 : MonoBehaviour
{
    public GameObject fish3;
    public Text fish,coins,die;
    public int scoref=0;
    public int incf=1;
    public int coin=0;
    public int incc=10;
    public int dienum=20;
    public int decd=1;




    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Gameover();
    }
    void OnTriggerEnter2D(Collider2D trigger)
    {
        if(trigger.gameObject.tag=="shark")
        {
            transform.position = new Vector3(0f, -4.77f, 0f);
            dienum=dienum-decd;
            die.text=dienum.ToString();
        }
        else if(trigger.gameObject.tag=="boat")
        {
            transform.position = new Vector3(0f, -4.77f, 0f);
            dienum=dienum-decd;
            die.text=dienum.ToString();
        }
        else if(trigger.gameObject.tag=="scaryfish")
        {
            transform.position = new Vector3(0f, -4.77f, 0f);
            dienum=dienum-decd;
            die.text=dienum.ToString();
        }
        else if(trigger.gameObject.tag=="whale")
        {
            transform.position = new Vector3(0f, -4.77f, 0f);
            dienum=dienum-decd;
            die.text=dienum.ToString();
        }
        else if(trigger.gameObject.tag=="seaweed4")
        {
            transform.parent = trigger.gameObject.transform;
        }
        else if(trigger.gameObject.tag=="seaweed3")
        {
            transform.parent = trigger.gameObject.transform;
        }
        else if(trigger.gameObject.tag=="shell2")
        {
            transform.parent = trigger.gameObject.transform;
        }
        else if(trigger.gameObject.tag=="shell3")
        {
            transform.parent = trigger.gameObject.transform;
        }
        else if(trigger.gameObject.tag=="background")
        {
            transform.position = new Vector3(0f, 0.37f, 0f);
            dienum=dienum-decd;
            die.text=dienum.ToString();
        }
        else if(trigger.gameObject.tag=="coral")
        {
            scoref=scoref+incf;
            fish.text=scoref.ToString();
            coin=coin+incc;
            coins.text=coin.ToString();
            transform.position = new Vector3(0f, -4.77f, 0f);
            fish3.transform.parent=null;

        }
    }
    void Gameover(){
        if(dienum==0){
            Destroy(gameObject);
            SceneManager.LoadScene(4);
        }
    }
}


