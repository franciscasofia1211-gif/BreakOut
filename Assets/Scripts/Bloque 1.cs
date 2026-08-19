using UnityEngine;

public class Bloque1 : MonoBehaviour
{
    public int resistencia;
    void Start()
    {
        resistencia = 4;
    }
    void Update()
    {
        if (resistencia <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    //la idea de este bloque es que retendra la bola durante unos segundos y luego lo hara rebotar, como un slime

    public virtual void RebotarBola()
    {
        
    } 

}
