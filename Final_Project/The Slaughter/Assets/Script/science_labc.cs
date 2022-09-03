using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class science_labc : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        science_labconvert();
    }
    public void science_labconvert(){
        SceneManager.LoadScene(6);
    }
}
