using UnityEngine;

public class Jugador : MonoBehaviour
{

    [SerializeField] public int Tope = 23;
    [SerializeField] public int Velocity = 10;
    Vector3 MousePos2d;
    Vector3 MousePos3D;

    private void Update()
    {
        MousePos2d = Input.mousePosition;
        MousePos2d.z = -Camera.main.transform.position.z;
        MousePos3D = Camera.main.ScreenToWorldPoint(MousePos2d);

        Vector3 pos = this.transform.position;
        pos.x = MousePos3D.x;
        if (pos.x < -Tope)
        {
          //pos.x = -Tope;
        }
        else if (pos.x > Tope)
        {
          //pos.x = Tope;
        }
        this.transform.position = pos;
        //float h = Input.GetAxis("Horizontal") * Velocity * Time.deltaTime;
        //transform.Translate(h,0,0);
    }
}
