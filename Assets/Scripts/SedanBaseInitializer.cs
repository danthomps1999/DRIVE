using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SedanBaseInitializer : MonoBehaviour
{

    public CarType carType;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Initialize(CarType carType){
        GetComponentInChildren<Renderer>().material = carType.CarMaterial; 
    }
}
