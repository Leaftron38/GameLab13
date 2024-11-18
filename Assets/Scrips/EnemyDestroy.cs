using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroy : MonoBehaviour
{
    public GameObject Explosion;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "bala")
        {
            Instantiate(Explosion, transform.position, transform.rotation);
            Destroy(this.gameObject);
            
        }
    }
}
