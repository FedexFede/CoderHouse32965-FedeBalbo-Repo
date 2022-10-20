using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDeLaClase : MonoBehaviour
{
    public GameObject objetoAInstanciar;
    public Transform lugar;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(objetoAInstanciar, lugar.position, transform.rotation); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
