using UnityEngine;

public class Bloque2 : Bloque1
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
            resistencia = 5;
        }
    }
    //la idea de este bloque es devolver con el doble de fuerza la bola, como un bloque de lava

    public override void RebotarBola(Collision collision)
    {
        base.RebotarBola(collision);
    }
}
