using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Move(Vector3 direction){

        Vector3 destination=transform.position+direction;
        Collider2D obstacle=Physics2D.OverlapBox(destination, Vector2.zero,0f,LayerMask.GetMask("Obstacle"));
        Collider2D platform=Physics2D.OverlapBox(destination, Vector2.zero,0f,LayerMask.GetMask("Platfrom"));

        if(obstacle !=null && platform==null){
            transform.position=destination;
            transform.position = new Vector3(0f, -147.4f, 0f);
        }
    }
    
    void OnTriggerEnter2D(Collider2D other){
        if(enabled && other.gameObject.layer==LayerMask.NameToLayer("Obstacle")&& transform.parent==null){
        transform.position = new Vector3(0f, -147.4f, 0f);
        }
    }
}
