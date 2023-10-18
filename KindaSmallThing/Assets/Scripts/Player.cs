using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int speed = 10;
    private Rigidbody rb;
    public int jumpSt = 7;
    public bool floored;
    public Transform cameraPivot;
    private AudioSource source;

    void Start()
    {
        Debug.Log("START");
        TryGetComponent(out rb);
        TryGetComponent(out source);
    }

    private void OnCollisionEnter(Collision collision){
        if (!floored && collision.gameObject.tag == "Chão"){
            floored = true;
            }
        }

    void Update()
    {
        Debug.Log("UPDATE");
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 direcao = cameraPivot.forward * v + cameraPivot.right * h;
        rb.AddForce(direcao * speed * Time.deltaTime,ForceMode.Impulse);

        if (Input.GetKeyDown(KeyCode.Space) && floored){
            rb.AddForce(Vector3.up * jumpSt, ForceMode.Impulse);
            floored = false;
            source.Play();
        }

        if(transform.position.y <= -1){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
