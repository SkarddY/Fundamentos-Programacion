using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretMovement : MonoBehaviour
{
    [SerializeField] float magnitudAng;
    void Start()
    {
        
    }

    void Update()
    {
        Vector3 direccion = new Vector3(0, 1, 0) * Input.GetAxis("HorizontalTorreta");
        Vector3 velAng = magnitudAng * direccion;
        Vector3 distancia = velAng * Time.deltaTime;
        transform.eulerAngles += distancia;
    }
}
