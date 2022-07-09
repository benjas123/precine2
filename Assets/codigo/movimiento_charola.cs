using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento_charola : MonoBehaviour
{
    public float velocidad = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= transform.up * velocidad * Time.deltaTime;

    }
}
