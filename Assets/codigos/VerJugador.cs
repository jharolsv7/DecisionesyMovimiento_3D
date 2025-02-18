using UnityEngine;

public class VerJugador : MonoBehaviour
{
    
    public Transform objetivo;
    public float rangoVision = 50;
    public float rangoFOV = 30;
    private Vector3 jugadorDesdeIA;
    private float distanciaAlJugador=0;
    public float angulo = 0; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool visto = false;
        distanciaAlJugador = Vector3.SqrMagnitude(transform.position - objetivo.position);
        if(distanciaAlJugador <= (rangoVision * rangoVision))
        {
            jugadorDesdeIA = objetivo.position - transform.position;
            angulo = Vector3.Angle(transform.forward, jugadorDesdeIA);
            if(angulo <= rangoFOV)
            {
                visto = true;
                if(visto)
                {
                    Debug.Log("Jugador visto");
                }else
                {
                    Debug.Log("Jugador no visto");
                }
            }
        }   
    }
}
