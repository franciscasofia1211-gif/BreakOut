using UnityEngine;

public class Bloque5 : Bloque1
{
    void Start()
    {
        if (opciones.NivelDificultad == Opciones.dificultad.facil)
        {
            resistencia = 2;
        }
        if (opciones.NivelDificultad == Opciones.dificultad.normal)
        {
            resistencia = 3;
        }
        if (opciones.NivelDificultad == Opciones.dificultad.dificil)
        {
            resistencia = 4;
        }
    }
    public override void RebotarBola(Collision collision)
    {
        base.RebotarBola(collision);
    }
}
