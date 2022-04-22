using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDimper : MonoBehaviour
{
    public GameObject dimper;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBigGuy", 0f, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnBigGuy()
    {
        GameObject d = Instantiate(dimper);
        d.SetActive(true);
    }
}
