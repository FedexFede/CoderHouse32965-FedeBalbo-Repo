using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirObjecto : MonoBehaviour
{
    public float destroyTime;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,destroyTime);
    }
}
