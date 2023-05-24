using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rkt_Script : MonoBehaviour
{
    public Transform anchorTrack, racket_T;
    private Vector3 newPos, fin_velocity;
    private Quaternion newRtt;
    private Rigidbody rb;
    float force = 10f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        newPos = anchorTrack.transform.position;
        newRtt = anchorTrack.transform.rotation;
        racket_T.GetComponent<Rigidbody>().MovePosition(newPos);
        racket_T.GetComponent<Rigidbody>().MoveRotation(newRtt);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {
            //other.GetComponent<Rigidbody>().velocity = new Vector3(-3.5f, -2.0f, 0.5f);
        }
    }
}
