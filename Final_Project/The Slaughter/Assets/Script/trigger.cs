using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class trigger : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnTriggerEnter2D(Collider2D trigger)
    {
        if(trigger.gameObject.tag=="astroid1")
        {
            transform.position = new Vector3(0f, -147.4f, 0f);
        }
        else if(trigger.gameObject.tag=="alien")
        {
            transform.position = new Vector3(0f, -147.4f, 0f);
        }
        else if(trigger.gameObject.tag=="Galaxy_transport")
        {
            transform.position = new Vector3(0f, 8.4f, 0f);
        }
        else if(trigger.gameObject.tag=="Background")
        {
            transform.position = new Vector3(0f, 8.4f, 0f);
        }
        else if(trigger.gameObject.tag=="alien2")
        {
            transform.position = new Vector3(0f, -147.4f, 0f);
        }
        else if(trigger.gameObject.tag=="astroid")
        {
            transform.position = new Vector3(0f, -147.4f, 0f);
        }
        else if(trigger.gameObject.tag=="plants1")
        {
            transform.parent = trigger.gameObject.transform;
        }
        else if(trigger.gameObject.tag=="plants2")
        {
            transform.parent = trigger.gameObject.transform;
        }
        else if(trigger.gameObject.tag=="bluegalaxy1")
        {
            transform.parent = trigger.gameObject.transform;
        }
        else if(trigger.gameObject.tag=="bluegalaxy4")
        {
            transform.parent = trigger.gameObject.transform;
        }
    }
    void OnTriggerExit2D(Collider2D other){
        transform.parent=null;
    }
}
