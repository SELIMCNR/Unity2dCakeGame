using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hamburger : MonoBehaviour
{
    public float donme;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * donme;
    }
}
