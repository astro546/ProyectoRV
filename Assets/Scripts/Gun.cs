using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawnPoint;

    public float bulletSpeed = 10;

    public void Fire() {
        Quaternion bulletRotation = bulletSpawnPoint.rotation * Quaternion.Euler(0.0f, 0.0f, 0.0f);
        var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletRotation);
        bullet.GetComponent<Rigidbody>().velocity = -bulletSpawnPoint.right * bulletSpeed;
    }
}
