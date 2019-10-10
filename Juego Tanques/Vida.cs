using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float health = 100;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Bala2"))
        {
            health = health - 20;

            if (health == 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
