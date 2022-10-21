using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssetMove : MonoBehaviour
{
    public float speed = 10f;
    public Vector3 posIn;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 posIn = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.forward * speed * Time.deltaTime;
        
    }
}