using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssetMove : MonoBehaviour
{

    [SerializeField] Transform playerTransform;
    [SerializeField] Movimientos style;
    public float speed = 10f;
    public Vector3 posIn;
    public float lookSpeed = 3f;
    public float girarVelocidad = 45f;
    public float perseguirDistancia = 25f;

    public enum Movimientos
    {
        Girar,
        Mirar,
        Perseguir,
    }


    // Start is called before the first frame update
    void Start()
    {
        //Vector3 posIn = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        SetStyle(style);        
    }

    private void SetStyle(Movimientos style)
    {
        switch (style)
        {
            case Movimientos.Mirar:
                transform.LookAt(playerTransform);
                break;

            case Movimientos.Perseguir:
                Perseguir();
                break;

            case Movimientos.Girar:
                transform.Rotate(Vector3.up * (girarVelocidad * Time.deltaTime));
                break;

            default:
                transform.position += Vector3.back * speed * Time.deltaTime;
                break;

        }
    }

    void Perseguir()
    {
        Quaternion newRotation = Quaternion.LookRotation((playerTransform.position - transform.position));

        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, lookSpeed * Time.deltaTime);

        float distance = (playerTransform.position - transform.position).magnitude;

        if (distance > perseguirDistancia)
        {
            Vector3 direction = (playerTransform.position - transform.position).normalized;
            transform.position += speed * direction * Time.deltaTime;
        }
    }
}