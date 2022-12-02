using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistoletusus : MonoBehaviour
{
    public Transform shotpos;
    public GameObject bullet;
    void Start()
    {
        
    }

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(bullet, shotpos.transform.position, transform.rotation);
        }
    }
}
