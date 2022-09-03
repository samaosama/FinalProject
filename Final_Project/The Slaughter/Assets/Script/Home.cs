using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Home : MonoBehaviour
{
    public GameObject fish;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnEnable(){
        fish.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D trigger){
        if(trigger.gameObject.tag=="Player"){
            enabled=true;
        }
    }
}
