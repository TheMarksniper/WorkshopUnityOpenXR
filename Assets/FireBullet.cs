using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullet : MonoBehaviour
{
    public GameObject bullet;
    public int force;
    public Transform startposition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shoot()
    {
        GameObject b = Instantiate(bullet);
        b.transform.position = startposition.position;
        Rigidbody rb = b.GetComponent<Rigidbody>();
        rb.AddForce(startposition.forward * force);
        CustomBullet cb = b.GetComponent<CustomBullet>();
        cb.enabled = true;
    }
}
