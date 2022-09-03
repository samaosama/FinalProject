using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class trigger3 : MonoBehaviour
{
    public GameObject bird1;
    public Text bird,coin,die;
    public int birds=0;
    public int incb=1;
    public int coins=0;
    public int incc=10;
    public int dieb=30;
    public int decb=1;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Gameover();
    }
    void OnTriggerEnter2D(Collider2D trigger){
        if(trigger.gameObject.tag=="enemy"){
        transform.position = new Vector3(0f, -4.1783f, 0f);
        dieb=dieb-decb;
        die.text=dieb.ToString();
        }
        else if(trigger.gameObject.tag=="platform"){
            transform.parent=trigger.gameObject.transform;
        }
        else if(trigger.gameObject.tag=="home"){
            birds=birds+incb;
            bird.text=birds.ToString();
            coins=coins+incc;
            coin.text=coins.ToString();
            transform.position = new Vector3(0f, -4.1783f, 0f);
            bird1.transform.parent=null;
        }
        else if(trigger.gameObject.tag=="background")
        {
            transform.position = new Vector3(0f, 0.54f, 0f);
            dieb=dieb-decb;
            die.text=dieb.ToString();
        }
    }
    void Gameover(){
        if(dieb==0){
            Destroy(gameObject);
            SceneManager.LoadScene(4);
        }
    }
}
