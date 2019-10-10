using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motor : MonoBehaviour
{
    [SerializeField] float magnitud = 8, magnitudAng = 10, cooldown=3, magFuerza = 300, salto=1500,saltoj2=1500;
    [SerializeField] AudioClip idle, driving;
    AudioSource audioMotor;
    Rigidbody rbd;
    float t = 0;
    void Start()
    {
        audioMotor = GetComponent<AudioSource>();
        rbd = GetComponent<Rigidbody>();
        t = cooldown;
    }

    bool PlayerInGround;
    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider.tag.Equals("Ground"))
        {
            PlayerInGround = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.tag.Equals("Ground"))
        {
            PlayerInGround = false;
        }
    }

    void Update()
    {  
        Vector3 direccion = transform.forward * Input.GetAxis("Vertical");
        Vector3 velocidad = magnitud * (direccion);
        Vector3 distancia = velocidad * Time.deltaTime;
        transform.position += distancia;

        Vector3 direccionA = new Vector3(0, 1, 0) * Input.GetAxis("Horizontal");
        Vector3 velAng = magnitudAng * direccionA;
        Vector3 distAng = velAng * Time.deltaTime;
        transform.eulerAngles += distAng;

        float sentidoj2 = 1;
        Vector3 dirj2 = new Vector3(0, 1, 0);
        Vector3 fuerzaj2 = saltoj2 * direccion * sentidoj2;
        if (Input.GetKeyDown(KeyCode.UpArrow) && PlayerInGround==true)
        {
            rbd.AddForce(fuerzaj2);
        }

        t += Time.deltaTime;

        if ((t>=cooldown)&&Input.GetButtonDown("Jump"))
        {
            Vector3 dir = transform.forward * 0.7f + transform.up * 0.3f;
            rbd.AddForce(dir*magFuerza);
            t = 0;
        }

        if (velocidad.magnitude > 1 || velAng.magnitude > 1)
        {
            audioMotor.clip = driving;
            if (!audioMotor.isPlaying) audioMotor.Play();
        }
        else
        {
            audioMotor.clip = idle;
            if (!audioMotor.isPlaying) audioMotor.Play();
        }

    }
}
