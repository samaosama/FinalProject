using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       Move();
    }
    void Move()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            transform.position+=Vector3.up;
        }
        
        else if(Input.GetKeyDown(KeyCode.S))
        {
            transform.position+=Vector3.down;
        }

        else if(Input.GetKeyDown(KeyCode.D))
        {
            transform.position+=Vector3.right;
        }

        else if(Input.GetKeyDown(KeyCode.A))
        {
            transform.position+=Vector3.left;
        }
    }

    void Move2(Vector3 direction)
    {
        Vector3 destination=transform.position+direction;
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
