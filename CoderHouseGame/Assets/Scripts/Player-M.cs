using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Variables

    public int vida;
    public int velocidad;
    public Vector3 direccion;

    // Start is called before the first frame update
    void Start()
    {
        vida = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
        {
            Move();
            Debug.Log("Me estoy moviendo!");
        }

        if (Input.GetKeyDown("d"))
        {
            int dano = 10;
            Damage(dano);
            Debug.Log("Recibo " + dano + " puntos de daño!" );
        }

        if (Input.GetKeyDown("c"))
        {
            int cura = 5;
            Heal(cura);
            Debug.Log("Recupero " + cura + " puntos de vida!");
        }
    }

    //Metodo para controlar el movimiento

    public void Move()
    {
        transform.Translate(direccion * velocidad * Time.deltaTime);
    }

    //Metodo que cure al jugador

    public void Heal(int healAmount)
    {
        vida += healAmount;
    }

    //Metodo que dane al jugador

    public void Damage(int damage)
    {
        vida -= damage;
    }
}
