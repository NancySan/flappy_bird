using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target; //variable para especificar que objeto se sigue

    // Update is called once per frame
    void LateUpdate() //para movimiento de la camara mas fluido
    {
        transform.position = new Vector3(target.position.x, transform.position.y, transform.position.z);
    }
}
