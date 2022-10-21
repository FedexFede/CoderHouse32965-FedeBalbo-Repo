using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssetRotate : MonoBehaviour
{
    //public float xRotation = 90.0f;
    //public float xRotation1 = 0.0f;
    public float RotationSpeed = 15.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(Vector3.up * (RotationSpeed * Time.deltaTime));


    }
}
