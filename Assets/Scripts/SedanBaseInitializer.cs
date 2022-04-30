using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SedanBaseInitializer : MonoBehaviour
{

    public CarType carType;

    int PreferredMaxSpeed;
    int PreferredTailingDistance;

    //Should I take it in like this, or do it differently?
    string Color;

    int OutlierValue;

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
