using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookShoot : MonoBehaviour
{
    public Transform player;

    [SerializeField] private float timer = 0.001f;
    private float bulletTime;



    public GameObject enemyBullet;
    public Transform spawnPoint;

    public float enemySpeed;
    


    
    void Update()
    {
        
        Vector3 direction = player.position - transform.position;
        direction.y = 0; 

       
        if (direction.sqrMagnitude > 0.01f)
        {
           
            Quaternion rotation = Quaternion.LookRotation(direction);

           
            transform.rotation = rotation;
        }

        ShootAtPlayer();
    }

    void ShootAtPlayer()
    {
        bulletTime -= Time.deltaTime;

        if(bulletTime > 0) return;

        bulletTime = timer;

        GameObject bulletObj = Instantiate(enemyBullet, spawnPoint.transform.position, spawnPoint.transform.rotation) as GameObject;
        Rigidbody bulletRig = bulletObj.GetComponent<Rigidbody>();
        bulletRig.AddForce(bulletRig.transform.forward * enemySpeed);
        Destroy(bulletObj, 5f);
    }

}
