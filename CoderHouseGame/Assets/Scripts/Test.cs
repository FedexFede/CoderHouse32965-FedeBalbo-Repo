using UnityEngine;

public class Test : MonoBehaviour

{
    public Vector3 rotateAmount;  
    public float cutSpeed;
    public Vector3 moveDirection;
    public Vector3 crecimiento;
 


    // Start is called before the first frame update
    void Start()
    {
     //RotateAmount.x = 180;
     Debug.Log(rotateAmount.x);

     transform.localScale += crecimiento;
    }

    // Update is called once per frame
    void Update()
    {
    transform.Rotate(rotateAmount * Time.deltaTime /cutSpeed);
      
    transform.position += moveDirection * Time.deltaTime/cutSpeed;
    }
}
