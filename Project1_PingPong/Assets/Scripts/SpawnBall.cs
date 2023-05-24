using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SpawnBall : MonoBehaviour

{
    private AudioSource audioSource;
    public AudioClip tablepong, racketpong;
    public GameObject ppball, nonDmHand;
    float spawnTime = 5.0f;
    float holdDown = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        ppball.transform.position = new Vector3(1.12f, 2.2f, -0.203f);
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(OVRInput.Get(OVRInput.RawAxis1D.LHandTrigger) > 0.55f)
        {
            holdDown += Time.deltaTime;
            if (holdDown > spawnTime)
            {
                ppball.transform.position = nonDmHand.transform.position;
                ppball.GetComponent<Rigidbody>().velocity = Vector3.zero;
            }
        } else
        {
            holdDown = 0f;
        }      
    }
    
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.name == "Ping Pong Table")
        {
            audioSource.clip = tablepong;
            audioSource.Play();
        } else if(other.gameObject.name == "Ping Pong Racket")
        {
            audioSource.clip = racketpong;
            audioSource.Play();
        }
    }
}
