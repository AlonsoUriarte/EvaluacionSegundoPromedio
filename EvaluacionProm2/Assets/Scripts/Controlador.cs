using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controlador : MonoBehaviour
{
    private Modelo modelo;
    GameObject temporalPersonajeRojo;
    GameObject TemporalPersonajeVerde;
    GameObject temporalPersonajeAzul;
    void Start()
    {
        modelo = GetComponent<Modelo>();
    }

    public void InstanciarPersonajeRojo()
    {
        temporalPersonajeRojo = Instantiate(modelo.personajes[0]);
        temporalPersonajeRojo.transform.position = modelo.spawnPoint.transform.position;

        
    }
    public void InstanciarPersonajeVerde()
    {
        TemporalPersonajeVerde = Instantiate(modelo.personajes[1]);
        TemporalPersonajeVerde.transform.position = modelo.spawnPoint.transform.position;

    }
    public void InstanciarPersonajeAzul()
    {
        temporalPersonajeAzul = Instantiate(modelo.personajes[2]);
        temporalPersonajeAzul.transform.position = modelo.spawnPoint.transform.position

    }
    public void Seleccion()
    {
        switch (modelo.personajesBoton)
        {
            case 0:
                InstanciarPersonajeRojo();
                break;
            
                
        }
    }
}
