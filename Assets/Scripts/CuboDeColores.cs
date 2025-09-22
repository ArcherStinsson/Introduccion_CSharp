using UnityEngine;

public class CuboDeColores : MonoBehaviour
{

    public Color cubo = Color.red;
    public float tamanio = 1.0f;

    public Rigidbody rb;
    public Renderer r;
    public Transform t;
    public float tamaniomaximo = 8.0f;
    public float velocidadcrecimiento = 2.0f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {   r=GetComponent<Renderer>();
        r.material.color=cubo;

        t=GetComponent<Transform>();
        t.localScale = Vector3.one * tamanio;

    }

    // Update is called once per frame
    void Update()
    {
       
            if (t.localScale.x < tamaniomaximo)
            {
               t.localScale += Vector3.one * velocidadcrecimiento * Time.deltaTime;
            }
        rb.AddForce(Vector3.right*10f);
    }
}
