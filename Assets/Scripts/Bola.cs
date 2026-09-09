using UnityEngine;
using UnityEngine.Events;

public class Bola : MonoBehaviour
{
    public bool IsGameStart = false;
    public float velocidadBola = 10;
    Vector3 ultimaPosicion = Vector3.zero;
    Vector3 direccion = Vector3.zero;
    Rigidbody Rigidbody;
    private ControlBordes control;
    public UnityEvent bolaDestruida;
    public Opciones opciones;
    private void Awake()
    {
        control = GetComponent<ControlBordes>();
    }
    private void Start()
    {
        Vector3 PosIni = GameObject.FindGameObjectWithTag("Jugador").transform.position;
        PosIni.y += 3;
        this.transform.position = PosIni;
        this.transform.SetParent(GameObject.FindGameObjectWithTag("Jugador").transform);
        Rigidbody = this.gameObject.GetComponent<Rigidbody>();
        velocidadBola = opciones.velocidadBola;
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
        if (control.salioAbajo)
        {
            bolaDestruida.Invoke();
            Destroy(this.gameObject);
        }
        if (control.salioArriba)
        {
            direccion = transform.position - ultimaPosicion;
            direccion.y *= -1;
            direccion = direccion.normalized;
            Rigidbody.linearVelocity = velocidadBola * direccion;
            control.salioArriba = false;
            control.enabled = false;
            Invoke("HabilitarControl", 0.5f);
        }
        if (control.salioDerecha)
        {
            direccion = transform.position - ultimaPosicion;
            direccion.x *= -1;
            direccion = direccion.normalized;
            Rigidbody.linearVelocity = velocidadBola * direccion;
            control.salioDerecha = false;
            control.enabled = false;
            Invoke("HabilitarControl", 0.5f);
        }
        if (control.salioIzquierda)
        {
            direccion = transform.position - ultimaPosicion;
            direccion.x *= -1;
            direccion = direccion.normalized;
            Rigidbody.linearVelocity = velocidadBola * direccion;
            control.salioIzquierda = false;
            control.enabled = false;
            Invoke("HabilitarControl", 0.5f);
        }
    }
    private void HabilitarControl()
    {
        control.enabled = true;
    }
    private void FixedUpdate()
    {
        ultimaPosicion = transform.position;
    }
    private void LateUpdate()
    {
        if (direccion != Vector3.zero) 
        {
            direccion = Vector3.zero;
        }
    }
}
