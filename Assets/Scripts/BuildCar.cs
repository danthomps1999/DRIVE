using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildCar : MonoBehaviour
{
    
    ArrayList cars;
    public GameObject car;

    // Start is called before the first frame update
    void Start()
    {
        this.cars = new ArrayList();

        buildFourMovingCubes();

        //buildCube();

        //addDriver();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void buildCube(){
        GameObject carCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //carCube.transform.localScale = new Vector3(10.0f, 10.0f, 100.0f);
        Instantiate(carCube, new Vector3(0.0f, 1.0f, 0.0f), Quaternion.identity);
    }

    public void buildFourMovingCubes(){
        GameObject carCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Instantiate(carCube, new Vector3(0.0f, 1.0f, 0.0f), Quaternion.identity);
    }
}
