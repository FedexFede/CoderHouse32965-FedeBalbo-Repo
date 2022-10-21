using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovJugador : MonoBehaviour
{
    public float speed = 20f;
    public GameObject cam1;
    public GameObject cam2;

    public float xRotation = 90.0f;
    public float xRotation1 = 0.0f;
    public float RotationSpeed = 8.0f;

    // Start is called before the first frame update
    void Start()
    {
        cam1.SetActive(true);
        cam2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Movement();

        if (Input.GetKeyDown(KeyCode.C))
        {
            ToggleCam();
        }


    }
    void Movement()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        transform.position += (move * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.up * (RotationSpeed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.down * (RotationSpeed * Time.deltaTime));
        }
    }

    void ToggleCam()
    {
        if (cam1.activeInHierarchy)
        {
            cam1.SetActive(false);
            cam2.SetActive(true);
        }
        else if (cam2.activeInHierarchy)
        {
            cam2.SetActive(false);
            cam1.SetActive(true);
        }
    }
}
