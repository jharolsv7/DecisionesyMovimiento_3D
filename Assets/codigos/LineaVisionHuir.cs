using UnityEngine;

public class LineaVisionHuir : MonoBehaviour
{
    public float velocidad = 5;
    public Transform objetivo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 punto = objetivo.position - transform.position;
        Vector3 vision = transform.position - punto;
        transform.LookAt(vision);
        transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
    }
}
