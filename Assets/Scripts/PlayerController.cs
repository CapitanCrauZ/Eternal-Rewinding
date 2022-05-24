using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float x,y;
    public float velocidadRotación;
    public float velocidadMovimiento;
    // public Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        // anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Con esto se definen los controles
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        //Con esto se mueve el personaje
        transform.Rotate(0, x * Time.deltaTime * velocidadRotación, 0);
        transform.Translate(0, 0, y * Time.deltaTime * velocidadMovimiento);

        // anim.SetFloat("VelX",x);
        // anim.SetFloat("VelY",y);
    }
}
