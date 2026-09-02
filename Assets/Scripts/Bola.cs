using UnityEngine;

public class Bola : MonoBehaviour
{
    public bool IsGameStart = false;
    public int velocidadBola = 10;
    private void Start()
    {
        Vector3 PosIni = GameObject.FindGameObjectWithTag("Jugador").transform.position;
        PosIni.y += 3;
        this.transform.position = PosIni;
        this.transform.SetParent(GameObject.FindGameObjectWithTag("Jugador").transform);
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            if (!IsGameStart) 
            { 
                IsGameStart = true;
                this.transform.SetParent(null);
                GetComponent<Rigidbody>().linearVelocity = velocidadBola * Vector3.up;
            }
        }
    }
}
