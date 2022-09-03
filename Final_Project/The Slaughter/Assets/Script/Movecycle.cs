using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movecycle : MonoBehaviour
{   
    public Vector2 direction=Vector2.right;
    public float speed=1f;
    public float size=1;

    private Vector3 leftEdge;
    private Vector3 rightEdge;

     void Start()
    {
        leftEdge=Camera.main.ViewportToWorldPoint(Vector3.zero);
        rightEdge=Camera.main.ViewportToWorldPoint(Vector3.right);
    }

    void Update()
    {
        if(direction.x>0 &&(transform.position.x-size)>rightEdge.x){
            Vector3 position=transform.position;
            position.x=leftEdge.x-size;
            transform.position=position;
        }

        else if(direction.x<0 &&(transform.position.x+size)<leftEdge.x){
            Vector3 position=transform.position;
            position.x=rightEdge.x+size;
            transform.position=position;
        }

        else{
            transform.Translate(direction*speed*Time.deltaTime);
        }
    }
}
