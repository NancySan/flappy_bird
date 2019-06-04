using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Bird : MonoBehaviour
{
    // Start is called before the first frame update

    //agregamos una nueva varable de velocidad
    public float speed = 2;

    //agregamos una variable de fuerza 

    public float force = 300;
    void Start()
    {
        //usamos la propiedad de velocidad de Ridigbody para que el ave vuele a la derecha en todo momento
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
        
    }

    // Update is called once per frame
    void Update()
    {
        //si se preciono la tecla espacio el ave vuela hacia arriba con la fuerza
        if (Input.GetKeyDown(KeyCode.Space))
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);
        GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;

    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        //Reiniciar juego cada que el ave colisione con el suelo u obstaculo
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); ;  //para reiniciar escena actual
    }
}
