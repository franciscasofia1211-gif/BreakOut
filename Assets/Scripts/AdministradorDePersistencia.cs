using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AdministradorDePersistencia : MonoBehaviour
{
    public List<PuntajePersistente> objetosAGuardar;

    private void OnEnable()
    {
        for (int i = 0; i < objetosAGuardar.Count; i++) 
        { 
            var so = objetosAGuardar[i];
            so.Cargar();
        }
    }

    private void OnDisable()
    {
        for(int i = 0; i < objetosAGuardar.Count; i++)
        {
            var so = objetosAGuardar[i];
            so.Guardar();
        }
    }
}
