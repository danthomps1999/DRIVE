using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildCar : MonoBehaviour
{
    
    List<GameObject> carsForward;
    List<GameObject> carsBackward;
    public GameObject car;

    // Start is called before the first frame update
    void Start()
    {
        this.carsForward = new List<GameObject>();
        this.carsBackward = new List<GameObject>();

        buildManyMovingCubes();

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

    public void buildManyMovingCubes(){
        GameObject carCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //Would be .5, but the asphalt is .1 up
        GameObject madeCube0 = Instantiate(carCube, new Vector3(2.0f, .6f, 0.0f), Quaternion.identity);
        GameObject madeCube1 = Instantiate(carCube, new Vector3(4.0f, .6f, 0.0f), Quaternion.identity);
        GameObject madeCube2 = Instantiate(carCube, new Vector3(6.0f, .6f, 0.0f), Quaternion.identity);
        GameObject madeCube3 = Instantiate(carCube, new Vector3(8.0f, .6f, 0.0f), Quaternion.identity);
        GameObject madeCube4 = Instantiate(carCube, new Vector3(10.0f, .6f, 0.0f), Quaternion.identity);

        GameObject madeCube5 = Instantiate(carCube, new Vector3(-10.0f, .6f, 100.0f), Quaternion.identity);
        GameObject madeCube6 = Instantiate(carCube, new Vector3(-8.0f, .6f, 100.0f), Quaternion.identity);
        GameObject madeCube7 = Instantiate(carCube, new Vector3(-6.0f, .6f, 100.0f), Quaternion.identity);
        GameObject madeCube8 = Instantiate(carCube, new Vector3(-4.0f, .6f, 100.0f), Quaternion.identity);
        GameObject madeCube9 = Instantiate(carCube, new Vector3(-2.0f, .6f, 100.0f), Quaternion.identity);

        Destroy(carCube);
        //madeCube.transform.position += Vector3.forward * Time.deltaTime;
        this.carsForward.Add(madeCube0);
        this.carsForward.Add(madeCube1);
        this.carsForward.Add(madeCube2);
        this.carsForward.Add(madeCube3);
        this.carsForward.Add(madeCube4);

        this.carsBackward.Add(madeCube5);
        this.carsBackward.Add(madeCube6);
        this.carsBackward.Add(madeCube7);
        this.carsBackward.Add(madeCube8);
        this.carsBackward.Add(madeCube9);

    }

    public void moveCars(){
        foreach (GameObject car in this.carsForward)
        {
            car.transform.position += Vector3.forward * Time.deltaTime * 10;
        }

        foreach (GameObject car in this.carsBackward)
        {
            car.transform.position += Vector3.forward * Time.deltaTime * -10;
        }
    }
}
