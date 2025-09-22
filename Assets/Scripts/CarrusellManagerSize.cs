using UnityEngine;

public class CarrusellManagerSize : MonoBehaviour
{
    public GameObject[] cubos = new GameObject[5];

    private int paso = 0;
    private bool cambio = false;
    private float temporizador = 0f;
    public float tiempoEntreCambios = 0.5f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            cambio = true;
            paso = 0;
            temporizador = 0f;
        }

        if (cambio)
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
                cambio = false; 
            }
        }
    }
}
