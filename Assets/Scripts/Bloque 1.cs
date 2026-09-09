using System;
using UnityEngine;
using UnityEngine.Events;

public class Bloque1 : MonoBehaviour
{
    public int resistencia;

    public UnityEvent SumarPuntaje;
    public Opciones opciones;
    void Start()
    {
        if (opciones.NivelDificultad == Opciones.dificultad.facil) 
        {
            resistencia = 5;
        }
        if (opciones.NivelDificultad == Opciones.dificultad.normal) 
        {
            resistencia = 7;
        }
        if (opciones.NivelDificultad == Opciones.dificultad.dificil) 
        {
            resistencia = 10;
        }
    }
    void Update()
    {
        if (resistencia <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    //la idea de este bloque es que retendra la bola durante unos segundos y luego lo hara rebotar, como un slime

    public virtual void RebotarBola(Collision collision)
    {
        Vector3 direction = collision.contacts[0].point - transform.position;
        direction = direction.normalized;
        collision.rigidbody.linearVelocity = collision.gameObject.GetComponent<Bola>().velocidadBola * direction;
        resistencia--;
        SumarPuntaje.Invoke();
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bola"))
        {
            RebotarBola(collision);
        }
    }
}
