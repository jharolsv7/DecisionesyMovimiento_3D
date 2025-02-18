using UnityEngine;

public class Intercepcion : MonoBehaviour
{
    public GameObject objetivo;
    public GameObject prediccion;
    public float velocidad = 5;
    private Vector3 velRelativa;
    private Vector3 miVelocidad;

    private Vector3 velObjetivo;
    private Vector3 miPosAnterior;
    private Vector3 objPosAnterior;
    private float tiempoIntercepcion;
    private Vector3 distanciaRelativa;
    private Vector3 posFutura;
    private Vector3 posPrediccion; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        miPosAnterior = transform.position;
        objPosAnterior = objetivo.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        miVelocidad = (transform.position - miPosAnterior) / Time.deltaTime;
        miPosAnterior = transform.position;

        velObjetivo = (objetivo.transform.position - objPosAnterior) / Time.deltaTime;
        objPosAnterior = objetivo.transform.position;

        velRelativa = miVelocidad - velObjetivo;
        distanciaRelativa = objetivo.transform.position - transform.position;


        tiempoIntercepcion = distanciaRelativa.magnitude / (velRelativa.magnitude);
        posFutura = objetivo.transform.position + (velObjetivo * tiempoIntercepcion);
        posPrediccion = new UnityEngine.Vector3(posFutura.x, transform.position.y, posFutura.z);

        transform.LookAt(posPrediccion);
        prediccion.transform.position = posPrediccion;

        transform.Translate(UnityEngine.Vector3.forward * velocidad * Time.deltaTime);
    }
}