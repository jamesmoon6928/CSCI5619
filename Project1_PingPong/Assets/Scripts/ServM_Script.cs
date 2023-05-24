using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServM_Script : MonoBehaviour
{
    public GameObject ppball;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BtnDown();
    }

    void BtnDown() {
        if(OVRInput.GetDown(OVRInput.Button.One)) {
            ppball.transform.position = new Vector3(-1.202f, 0.971f, 0.044f);
            ppball.GetComponent<Rigidbody>().velocity = new Vector3(3.5f, -2.0f, 0.5f);
        }
    }
}
