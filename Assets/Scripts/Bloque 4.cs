using UnityEngine;

public class Bloque4 : Bloque1
{
    void Start()
    {
        if (opciones.NivelDificultad == Opciones.dificultad.facil)
        {
            resistencia = 3;
        }
        if (opciones.NivelDificultad == Opciones.dificultad.normal)
        {
            resistencia = 4;
        }
        if (opciones.NivelDificultad == Opciones.dificultad.dificil)
        {
            resistencia = 6;
        }
    }
    public override void RebotarBola(Collision collision)
    {
        base.RebotarBola(collision);
    }
}
