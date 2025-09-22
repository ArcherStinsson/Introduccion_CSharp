using UnityEngine;

public class ColorInesperado : MonoBehaviour
{
    private Renderer rend;
    public Color colorEsperado;

    void Start()
    {
        rend = GetComponent<Renderer>();
       
       
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           
            rend.material.color = colorEsperado;
        }
    }
}
