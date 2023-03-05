using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravitychange : MonoBehaviour
{
    public Collider coll;
    public 
    // Start is called before the first frame update
    void Start()
    {
        coll = GetComponent<Collider>();
        coll.isTrigger = true;
    }

    void OnTriggerEnter(Collider ram)
    {
        if (ram.tag == "rotating plane")
        {
            ram.attachedRigidbody.useGravity = true;
        }
            
    }
    // Update is called once per frame
    void Update()
    {
        OnTriggerEnter(coll);
    }
}
