using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controles : MonoBehaviour
{
    public Transform cubo;
    public float velocidad;
    public float velocidadgiro;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow)){
            cubo.Translate(Vector3.forward*velocidad);
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            cubo.Translate(Vector3.back*velocidad);
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            cubo.Rotate(Vector3.down*velocidadgiro);
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            cubo.Rotate(Vector3.up*velocidadgiro);
        }
    }
}
