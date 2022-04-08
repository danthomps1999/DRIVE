using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildWorld : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        buildGround();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void buildGround(){
        GameObject groundPlane = GameObject.CreatePrimitive(PrimitiveType.Plane);
        groundPlane.transform.localScale = new Vector3(10.0f, 10.0f, 10.0f);
        Instantiate(groundPlane, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
    }
    
}
