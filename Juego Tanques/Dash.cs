using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motor : MonoBehaviour
{
    [SerializeField] float magnitud = 8, magnitudAng = 10;
    [SerializeField] AudioClip idle, driving;
    AudioSource audioMotor;
    Rigidbody rbd;
    void Start()
    {
        audioMotor = GetComponent<AudioSource>();
        rbd = GetComponent<Rigidbody>();
    }


    void Update()
    {
        float magFuerza = 300;
        float sentido = 1;
        Vector3 dir = transform.forward;
        Vector3 fuerza1 = magFuerza * dir * sentido;

        Vector3 dir2 = new Vector3(0, 1, 0);
        Vector3 fuerza2 = magFuerza * dir2 * sentido;

        Vector3 direccion = transform.forward * Input.GetAxis("Vertical");
        Vector3 velocidad = magnitud * (direccion);
        Vector3 distancia = velocidad * Time.deltaTime;
        transform.position += distancia;

        Vector3 direccionA = new Vector3(0, 1, 0) * Input.GetAxis("Horizontal");
        Vector3 velAng = magnitudAng * direccionA;
        Vector3 distAng = velAng * Time.deltaTime;
        transform.eulerAngles += distAng;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rbd.AddForce(fuerza1);
            rbd.AddForce(fuerza2);
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
