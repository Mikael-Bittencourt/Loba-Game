using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D (Collider2D other)
   {
     if(other.CompareTag("hallway"))
     {
         SceneManager.LoadScene("level 2");
     }

     if(other.CompareTag("hallway 2"))
     {
         SceneManager.LoadScene("level 3");
     }


   }


}

