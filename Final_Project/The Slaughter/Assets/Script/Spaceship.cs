using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    float moveHorizontal;
    float moveVertical;
 

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void FixedUpdate()
    {
        Move();
        
    }
    void Move()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(moveHorizontal * speed, moveVertical * speed);
        
    }
    void Move2(Vector3 direction)
    {
        Vector3 destination=transform.position+Vector3.up;
        StartCoroutine(Leap(destination));
    }
    private IEnumerator Leap(Vector3 destination)
    {
        Vector3 startPosition=transform.position;
        float elapsed=0f;
        float duration=0.125f;

        while(elapsed<duration)
        {
            float t=elapsed/duration;
            transform.position=Vector3.Lerp(startPosition,destination,t);
            elapsed+=Time.deltaTime;
            yield return null;
        }
        transform.position=destination;
    }
    }
   

