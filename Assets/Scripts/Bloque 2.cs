using UnityEngine;

public class Bloque2 : Bloque1
{

    void Start()
    {
        resistencia = 2;
    }
    //la idea de este bloque es devolver con el doble de fuerza la bola, como un bloque de lava

    public override void RebotarBola()
    {
        base.RebotarBola();
    }
}
