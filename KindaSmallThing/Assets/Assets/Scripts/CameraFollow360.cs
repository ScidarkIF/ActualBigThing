using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow360 : MonoBehaviour
{

    private Transform target;
    private Vector3 offset;
    public float sensib = 2;
    private float yaw = 0;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindWithTag("Player").transform;
        offset = target.position - transform.position;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position - offset;
        yaw += sensib * Input.GetAxis("Mouse X");
        transform.eulerAngles = new Vector3(0, yaw, 0);
    }
}
