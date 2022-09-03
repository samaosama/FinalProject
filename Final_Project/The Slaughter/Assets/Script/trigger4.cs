using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class trigger4 : MonoBehaviour
{
    public GameObject player1;
    public Text player,coin,die;
    public int players=0;
    public int incp=1;
    public int coins=0;
    public int incc=10;
    public int diep=30;
    public int decp=1;

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
        transform.position = new Vector3(0f, -4.79f, 0f);
        diep=diep-decp;
        die.text=diep.ToString();
        }
        else if(trigger.gameObject.tag=="platform"){
            transform.parent=trigger.gameObject.transform;
        }
        else if(trigger.gameObject.tag=="home"){
            players=players+incp;
            player.text=players.ToString();
            coins=coins+incc;
            coin.text=coins.ToString();
            transform.position = new Vector3(0f, -4.79f, 0f);
            player1.transform.parent=null;
        }
        else if(trigger.gameObject.tag=="background")
        {
            transform.position = new Vector3(0f, 0.41f, 0f);
            diep=diep-decp;
            die.text=diep.ToString();
        }
    }
    void Gameover(){
        if(diep==0){
            Destroy(gameObject);
            SceneManager.LoadScene(4);
        }
    }
}
