using UnityEngine;

public class Bloque1 : MonoBehaviour
{
    public int resistencia;
    void Update()
    {
        if (resistencia <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
