using UnityEngine;

public class Bloque3 : Bloque1
{
    void Start()
    {
        if (opciones.NivelDificultad == Opciones.dificultad.facil)
        {
            resistencia = 3;
        }
        if (opciones.NivelDificultad == Opciones.dificultad.normal)
        {
            resistencia = 6;
        }
        if (opciones.NivelDificultad == Opciones.dificultad.dificil)
        {
            resistencia = 8;
        }
    }
    public override void RebotarBola(Collision collision)
    {
        base.RebotarBola(collision);
    }
}
