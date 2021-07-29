using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lifelines : MonoBehaviour
{
    // Start is called before the first frame update
    float health=11f; //No. of lifelines
    int obj=3;
    private void OnCollisionEnter(Collision other) {
        
        if(other.gameObject.tag!="Hit" && other.gameObject.tag!="Found" && other.gameObject.tag!="Base")
        {
            health--;
            Debug.Log("Be careful, you will loose lifelines if you hit objects!\n");
            Debug.Log("Lifelines = "+health);
        }
        if(other.gameObject.tag=="Hit" && other.gameObject.tag!="Found" && other.gameObject.tag!="Base")
        {
            health-=0.5f;
            Debug.Log("You're loosing lifelines! Don't hit the same thing again\n");
            Debug.Log("Lifelines remaining are "+health);
        }
        
        if(other.gameObject.tag=="Found")
        {
            health+=0.5f;
            Debug.Log("You've recahed a target and hence you gained some health!\n");
            Debug.Log("Lifelines remaining are "+health);
            other.gameObject.tag="Foundit";
            obj--;
            if(obj==0)
            {
                Debug.Log("Task Completed in "+Time.time);
                Time.timeScale = 0;
            }
        }

        if(health<=0)
        {
            Debug.Log("Total lifelines=0 and your score is: "+Time.time);
            Time.timeScale = 0;
        }
        
    }
}
