using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int speed = 10;
    private Rigidbody rb;

    void Start()
    {
        Debug.Log("START");
        TryGetComponent(out rb);
    }

    void Update()
    {
        Debug.Log("UPDATE");
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(h,0,v);
        rb.AddForce(direction * speed * Time.deltaTime,ForceMode.Impulse);

        if(transform.position.y <= -1){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
