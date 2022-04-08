using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildCar : MonoBehaviour
{
    
    List<GameObject> cars;
    public GameObject car;

    // Start is called before the first frame update
    void Start()
    {
        this.cars = new List<GameObject>();

        buildFourMovingCubes();

        //buildCube();

        //addDriver();
    }

    // Update is called once per frame
    void Update()
    {
        moveCars();
    }

    public void buildCube(){
        GameObject carCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //carCube.transform.localScale = new Vector3(10.0f, 10.0f, 100.0f);
        Instantiate(carCube, new Vector3(0.0f, 1.0f, 0.0f), Quaternion.identity);
    }

    public void buildFourMovingCubes(){
        GameObject carCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //Would be .5, but the asphalt is .1 up
        GameObject madeCube0 = Instantiate(carCube, new Vector3(4.0f, .6f, 0.0f), Quaternion.identity);
        GameObject madeCube1 = Instantiate(carCube, new Vector3(10.0f, .6f, 0.0f), Quaternion.identity);
        GameObject madeCube2 = Instantiate(carCube, new Vector3(-10.0f, .6f, 0.0f), Quaternion.identity);
        GameObject madeCube3 = Instantiate(carCube, new Vector3(-4.0f, .6f, 0.0f), Quaternion.identity);

        Destroy(carCube);
        //madeCube.transform.position += Vector3.forward * Time.deltaTime;
        this.cars.Add(madeCube0);
        this.cars.Add(madeCube1);
        this.cars.Add(madeCube2);
        this.cars.Add(madeCube3);

    }

    public void moveCars(){
        foreach (GameObject car in this.cars)
        {
            car.transform.position += Vector3.forward * Time.deltaTime * 10;
        }
    }
}
