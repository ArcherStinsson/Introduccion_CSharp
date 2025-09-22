using UnityEngine;

public class ControladorMovimientoBasico : MonoBehaviour
{

    private Transform t;
    public float velocidad = 3.0f;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        t = transform;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = 0f;
        if (Input.GetKey(KeyCode.A)) horizontal -= 1f;
        if (Input.GetKey(KeyCode.D)) horizontal += 1f;

      

        float vertical = 0f;
        if(Input.GetKey(KeyCode.S)) vertical -= 1f;
        if(Input.GetKey(KeyCode.W)) vertical += 1f;

        t.Translate(new Vector3(horizontal * velocidad * Time.deltaTime, 0, vertical * velocidad * Time.deltaTime)); // en el ejercicio 3 el error corresponde a la t de translate que está en minuscula y se pone en mayus.





    }
}
