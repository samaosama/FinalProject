using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pink_tube : MonoBehaviour
{
    public GameObject tube;
    public Text tube1,coin,break1;
    public int scoret=0;
    public int inct=1;
    public int coinc=0;
    public int incc=10;
    public int breakt=30;
    public int decs=1;


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
        if(trigger.gameObject.tag=="micro")
        {
            transform.position=new Vector3(0f,-4.6057f,0f);
            breakt=breakt-decs;
            break1.text=breakt.ToString();
        }
        else if(trigger.gameObject.tag=="cell")
        {
            transform.position=new Vector3(0f,-4.6057f,0f);
            breakt=breakt-decs;
            break1.text=breakt.ToString();
        }
        else if(trigger.gameObject.tag=="strand")
        {
            transform.position=new Vector3(0f,-4.6057f,0f);
            breakt=breakt-decs;
            break1.text=breakt.ToString();
        }
        else if(trigger.gameObject.tag=="cell")
        {
            transform.position=new Vector3(0f,-4.6057f,0f);
            breakt=breakt-decs;
            break1.text=breakt.ToString();
        }
        else if(trigger.gameObject.tag=="magnet")
        {
            transform.position=new Vector3(0f,-4.6057f,0f);
            breakt=breakt-decs;
            break1.text=breakt.ToString();
        }
        else if(trigger.gameObject.tag=="cell")
        {
            transform.position=new Vector3(0f,-4.6057f,0f);
            breakt=breakt-decs;
            break1.text=breakt.ToString();
        }
        else if(trigger.gameObject.tag=="lense1")
        {
            transform.parent = trigger.gameObject.transform;
        }
        else if(trigger.gameObject.tag=="lense2")
        {
            transform.parent = trigger.gameObject.transform;
        }
        else if(trigger.gameObject.tag=="tube1")
        {
            transform.parent = trigger.gameObject.transform;
        }
        else if(trigger.gameObject.tag=="tube2")
        {
            transform.parent = trigger.gameObject.transform;
        }
        else if(trigger.gameObject.tag=="background")
        {
            transform.position=new Vector3(0f,0.1f,0f);
            breakt=breakt-decs;
            break1.text=breakt.ToString();
        }
        else if(trigger.gameObject.tag=="stand")
        {
            scoret=scoret+inct;
            tube1.text=scoret.ToString();
            coinc=coinc+incc;
            coin.text=coinc.ToString();
            transform.position=new Vector3(0f,-4.6057f,0f);
            tube.transform.parent=null;
        }
    }
    void Gameover(){
        if(breakt==0){
            Destroy(gameObject);
            SceneManager.LoadScene(4);
        }
    }
}
    
