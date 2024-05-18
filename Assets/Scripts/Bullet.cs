using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision){
        if (collision.gameObject.CompareTag("Zombie")){
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 1.0f);
    }
}
