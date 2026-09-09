using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    public GameObject menuPausa;
    public GameObject MenuOpciones;

    public void MostrarMenuPausa()
    {
        menuPausa.SetActive(true);
        if (MenuOpciones.activeInHierarchy)
        {
            MenuOpciones.SetActive(false);
        }
    }
    public void OcultarMenuPausa()
    {
        menuPausa.SetActive(false);
    }
    public void RegresarAPantallaPrincipal()
    {
        SceneManager.LoadScene(0);
    }
    public void MostrarMenuOpciones()
    {
        menuPausa.SetActive(false);
        MenuOpciones.SetActive(true);
    }
}
