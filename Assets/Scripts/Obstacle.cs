using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    //agregamos una variable de velocidad 
    public float speed = 0;

    //variable para especificar la hora que se debe de llamar a Switch
    public float switchTime = 2;


    // Start is called before the first frame update
    void Start()
    {
        //configuramos la velocidad del ridigbody para que los obstaculos se muevan hacia arriba con la velocidad
        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;

        InvokeRepeating("Switch", 0, switchTime); //para revertir esa velocidad cada pocos segundos 
    }

    // Update is called once per frame
    void Switch()
    {
        GetComponent<Rigidbody2D>().velocity *= -1; 
    }
}
