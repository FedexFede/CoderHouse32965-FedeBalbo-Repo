using UnityEngine;

public class HPmgmt : MonoBehaviour
{

    public float vida = 100;
    public float velocidad = 1;
    public Vector3 direccion;
    public Vector3 rotateAmount;  
    //public float cutSpeed;
    //public Vector3 moveDirection;
    float randomNumber;
    float currentTime;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
     
      Movimiento(velocidad,ref direccion,rotateAmount);
        
      currentTime += Time.deltaTime;
      if (currentTime >= 1f)
       {
            Regeneration();
            Regeneration();
            currentTime = 0f;
       }

    }

    public void Regeneration ()
    {
      randomNumber = Random.Range(0, 100);
      Debug.Log("random number ="+ randomNumber);

      if (randomNumber >=50)
      {
        Heal(ref vida);

        }
        else
        {
        Damage(ref vida);
      }
      Debug.Log("vida ="+ vida);

    }

    public void Heal(ref float vida)
    {
     vida+= randomNumber = Random.Range(0, 10);
     GameObject.Find("Cube").GetComponent<Renderer>().material.color = Color.green;

    }

    public void Damage (ref float vida)
    {
     vida-= randomNumber = Random.Range(0, 10);
     GameObject.Find("Cube").GetComponent<Renderer>().material.color = Color.red;

    }

    public void Movimiento (float velocidad, ref Vector3 direccion, Vector3 rotateAmount)
    {
     transform.Rotate(rotateAmount * Time.deltaTime * velocidad);
     transform.position += direccion * Time.deltaTime * velocidad ;
    }
}
