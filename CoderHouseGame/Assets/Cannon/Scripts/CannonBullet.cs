using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class CannonBullet : MonoBehaviour
{
    /* >> Consigna: Se deberá, partiendo de la escena entregada más abajo:
Crear un prefab de bala (esfera) que tenga como variables expuestas speed, direction y damage.
Que la bala se mueva constantemente en la dirección direction, con una velocidad speed luego de ser instanciada.
Agregar código al script “Cañon” de manera que el método “Disparo” instancie un prefab de bala (puede ser una esfera).


>>Aspectos a incluir en el entregable:
Entregar el proyecto completo, con los scripts modificados y el prefab creado.

 */

    public float velocidad = 1;
    public Vector3 direccion;
    public float damage = 100;
    private bool resize = true;


    // Start is called before the first frame update
    void Start()
    {
        //direccion = Vector3.forward;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direccion.normalized * Time.deltaTime * velocidad;
        //transform.position += Vector3.forward * Time.deltaTime * velocidad;
        if (Input.GetKeyDown(KeyCode.Space)&& resize == true)
        {
            ResizeBullet();
        }

    }
    private void ResizeBullet()
    {
        transform.localScale = 2f * transform.localScale;
        resize = false;
    }

}
