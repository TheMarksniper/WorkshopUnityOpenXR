using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportBulletCollision : MonoBehaviour
{
    public GameObject xrRig;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hikuj");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collision");
        xrRig.transform.position = this.transform.position;
        //Destroy(this);
        
    }
}
