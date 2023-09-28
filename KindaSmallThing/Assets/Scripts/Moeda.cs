using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moeda : MonoBehaviour
{
    public int rpm = 50;

    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other){
        if (other.tag == "Player"){
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * rpm * Time.deltaTime, Space.World);
    }
}
