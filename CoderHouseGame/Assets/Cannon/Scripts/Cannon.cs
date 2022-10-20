using UnityEngine;

public class Cannon : MonoBehaviour
{
    /*
 * >> Consigna: Se deberá, partiendo de la escena entregada más abajo:
Crear un prefab de bala (esfera) que tenga como variables expuestas speed, direction y damage.
Que la bala se mueva constantemente en la dirección direction, con una velocidad speed luego de ser instanciada.
Agregar código al script “Cañon” de manera que el método “Disparo” instancie un prefab de bala (puede ser una esfera).


>> Aspectos a incluir en el entregable:
Entregar el proyecto completo, con los scripts modificados y el prefab creado.
*/
    public GameObject objetoAInstanciar;
    public Transform lugar;
    //public bool disparando = true;
    public float loadTime;
    private float reload;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.J) || Input.GetKeyDown(KeyCode.K) || Input.GetKeyDown(KeyCode.L) || Input.GetKeyDown(KeyCode.Z))
		{
			Shoot();
		}

        if (Input.GetKey(KeyCode.Z) )
        {
                ShootConstant();
                //loadTime = reload;
        }
        if (Input.GetKeyUp(KeyCode.Z))
        {
            //disparando = true;
            Debug.Log("The Cannon stopped firing");
        }

    }
	
	private void Shoot()
	{
        Instantiate(objetoAInstanciar, lugar.position, transform.rotation);
        Debug.Log("The Cannon has been shoot!");
	}
    private void ShootConstant()
    {
        //reload = loadTime;
        reload += Time.deltaTime;
        if (reload > loadTime)
        {
            //Instantiate(objetoAInstanciar, lugar.position, transform.rotation);
            //loadTime = reload;
            Shoot();
            Reload();
        }
        //disparando = false;
        //Debug.Log("The Cannon is being fired");
    }
    private void Reload()
    {
        reload = 0f;
    }


}
