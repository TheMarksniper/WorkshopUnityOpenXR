using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowAI : MonoBehaviour
{

public Transform target;
public Transform myTransform;

    // // Start is called before the first frame update
    // void Start()
    // {
    //
    // }

    // Update is called once per frame
    void Update()
    {
          transform.LookAt(target);
          transform.Translate(Vector3.forward*4*Time.deltaTime);
    }
}
