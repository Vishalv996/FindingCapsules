using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropdown : MonoBehaviour
{
    [SerializeField] float wait=3f;
    MeshRenderer rend;
    Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rend=GetComponent<MeshRenderer>();
        rigidbody=GetComponent<Rigidbody>();
        rend.enabled=false;
        rigidbody.useGravity=false;
    }

    // Update is called once per frame
    void Update()
    {
     
        if(Time.time>wait){
            rend.enabled=true;
        rigidbody.useGravity=true;
        }   
    }
}
