using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    public float velocidad = 15.0f;
    public float velocidadAngular = 60.0f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(new Vector3(0, -velocidadAngular * Time.deltaTime, 0));
        }
        if(Input.GetKey(KeyCode.D))
        {
            this.transform.Rotate(new Vector3(0, velocidadAngular * Time.deltaTime, 0));
        }
        if(Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(new Vector3(0, 0, velocidad * Time.deltaTime));
        }
        if(Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(new Vector3(0, 0, -velocidad * Time.deltaTime));
        }
    }
}
