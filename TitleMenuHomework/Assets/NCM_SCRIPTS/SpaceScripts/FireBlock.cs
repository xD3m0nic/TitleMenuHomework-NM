using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBlock : MonoBehaviour
{

    GameObject Temporary_Bullet_Handler;

    Rigidbody Temporary_RigidBody;

    public GameObject bulletPrefab;

    public GameObject startBulletHere;

    public int bulletForce = 10;

    public int bulletLifespan = 3;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            Fire();
        }
    }

    private void Fire()
    {
        Temporary_Bullet_Handler = Instantiate(bulletPrefab, startBulletHere.transform.position, startBulletHere.transform.rotation) as GameObject;

        Temporary_RigidBody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();

        Temporary_RigidBody.AddForce(Temporary_Bullet_Handler.transform.forward * bulletForce);

        Destroy(Temporary_Bullet_Handler, bulletLifespan);
    }
}
