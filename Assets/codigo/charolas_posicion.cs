using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class charolas_posicion : MonoBehaviour
{
   
    public GameObject charolas;
    public float tiempocre = 2f, rangoCreacion = 2, f;
    public Image UIImagen;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("creando",0.0F,tiempocre);
        //UIImagen = gameObject.Find("cambio").GetComponent<Image>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void creando()
    {
        Vector3 spawnPsosicion = new Vector3 (0, 0, 0);
        spawnPsosicion = this.transform.position + Random.onUnitSphere * rangoCreacion;
        spawnPsosicion = new Vector3(spawnPsosicion.x,this.transform.position.y , 0);

        GameObject charola = Instantiate (charolas , spawnPsosicion, Quaternion.identity);

    }
}
