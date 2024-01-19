using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaPersonaje : MonoBehaviour
{
    public float velocidadMove = 5f;
    public float velocidadRote = 200f;
    private Animator anim;
    public float x, y;
    public bool Atacar;
    public bool avanzar;
    public float impulsoGolpe=10f;
    public Rigidbody rb;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        if (Atacar == false)
        {
            transform.Rotate(0, x * Time.deltaTime * velocidadRote, 0);
            transform.Translate(0, 0, y * Time.deltaTime * velocidadMove);
        }

    }
    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        if(Input.GetKeyDown(KeyCode.Return) && Atacar==false) 
        {
            anim.SetTrigger("Golpe");
            Atacar = true;
        }
        anim.SetFloat("Velx", x);
        anim.SetFloat ("Vely", y);
    }
    public void NoGolpe()
    {
        Atacar = false;
        avanzar = false;
    }

}
