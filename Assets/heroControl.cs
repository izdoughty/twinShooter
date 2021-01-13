using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heroControl : MonoBehaviour { 
    public float xVelAdj;
    public float yVelAdj;
    public float xFire;
    public float yFire;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xVelAdj = Input.GetAxis("xMove");
        yVelAdj = Input.GetAxis("yMove");

        GetComponent<Rigidbody>().velocity = new Vector3 (3 * xVelAdj, 3 * yVelAdj, 0);
    }
}
