using UnityEngine;

public class CarruselManager : MonoBehaviour
{
    public GameObject[] cubos = new GameObject[5];

    private int paso = 0;
    private bool cambioColor = false;
    private bool cambioTamaño = false;

    private float temporizador = 0f;
    public float tiempoEntreCambios = 0.5f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            cambioColor = true;
            cambioTamaño = false;
            paso = 0;
            temporizador = 0f;
        }

        
        if (Input.GetKeyDown(KeyCode.K))
        {
            cambioTamaño = true;
            cambioColor = false;
            paso = 0;
            temporizador = 0f;
        }

        
        if (cambioColor)
        {
            temporizador += Time.deltaTime;

            if (temporizador >= tiempoEntreCambios && paso < cubos.Length)
            {
                Color color = Color.white;

                if (paso == 0) color = Color.red;
                else if (paso == 1) color = Color.green;
                else if (paso == 2) color = Color.blue;
                else if (paso == 3) color = Color.yellow;
                else if (paso == 4) color = Color.magenta;

                cubos[paso].GetComponent<Renderer>().material.color = color;

                paso++;
                temporizador = 0f;
            }
            else if (paso >= cubos.Length)
            {
                cambioColor = false;
            }
        }

        
        if (cambioTamaño)
        {
            temporizador += Time.deltaTime;

            if (temporizador >= tiempoEntreCambios && paso < cubos.Length)
            {
                cubos[paso].transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);

                paso++;
                temporizador = 0f;
            }
            else if (paso >= cubos.Length)
            {
                cambioTamaño = false;
            }
        }
    }
}
