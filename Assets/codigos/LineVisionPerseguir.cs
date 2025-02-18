using UnityEngine;

public class LineVisionPerseguir : MonoBehaviour
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
        transform.LookAt(objetivo);
        transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
    }
}
