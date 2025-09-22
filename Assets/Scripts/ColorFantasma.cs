using UnityEngine;

public class ColorFantasma : MonoBehaviour
{
    private Renderer rend;
    public Material materialFinal;

    void Start()
    {
        // ¡Esta línea está comentada a propósito!
        rend = GetComponent<Renderer>();
        rend.material=materialFinal;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
