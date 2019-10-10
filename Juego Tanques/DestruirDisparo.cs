using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoyShoot : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Player2")) Destroy(gameObject);
    }
}
