using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildWorld : MonoBehaviour
{

    public Material asphalt;

    public CarFactory CarFactory;


    // Start is called before the first frame update
    void Start()
    {

        buildGround();
        buildRoad();



    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void buildGround(){
        GameObject groundPlane = GameObject.CreatePrimitive(PrimitiveType.Plane);
        groundPlane.transform.localScale = new Vector3(10.0f, 10.0f, 100.0f);
        Instantiate(groundPlane, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
    }

    void buildRoad(){
        GameObject roadPlane = GameObject.CreatePrimitive(PrimitiveType.Plane);
        roadPlane.transform.localScale = new Vector3(4.0f, 10.0f, 100.0f);
        roadPlane.transform.position = new Vector3(0f, .1f, 0f);

        roadPlane.GetComponent<Renderer> ().material = asphalt;

        Instantiate(roadPlane, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
    }

    /*
    Can do it this way but it's bad for this purpose.
    private BuildCar carBuilder;
            //carBuilder = GetComponent<BuildCar>();
    would have to put the above in the start script to define the object


    void buildACar(){
        carBuilder.buildCube();
    }
    */
    
}
