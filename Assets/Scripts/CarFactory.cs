using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarFactory : MonoBehaviour
{

    public GameObject SedanBase;

    //Characteristics of a car:
    /*
    *   Preferred Top Speed
    *   Preferred Tailing Distance
    *   
    *
    *   Color
    *   CarType
    *
    *   Outlier Value
    */

    // Start is called before the first frame update
    void Start()
    {
        determineOutlierValue(Random.Range(0.0f, 1.0f));

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Needs to take in:
    /*
    *   Direction
    *   "Lane," basically, x/y position
    *   
    *   Should take in all of the values for a given car, I think?
    *   ->Currently rolls the stats randomly inside. Make the function take it all in?
    */
    void BuildRandomCar(){
        //Determine outlier value:
        float outlierValue = determineOutlierValue(Random.Range(0.0f, 1.0f));

        //Roll for top speed and color, using outlier value:


    }

    //TODO: Get this to determine a proper outlier value
    float determineOutlierValue(float x){
        float outlierValue;
        outlierValue = 0f;

        float E = 2.7182818284590451f;

        float a=1f;
        //float x=.5f;
        float b=0.5f;
        float c=1.0f;

        float numerator = Mathf.Pow(x - b, 2f);
        float denominator = Mathf.Pow(2 * Mathf.Pow(2 * c, 2f), 2f);
        float toTheE = -(numerator / denominator);

        outlierValue = a * Mathf.Pow(E, toTheE);

        //Debug.Log(a * Mathf.Pow(E, toTheE));
        Debug.Log(outlierValue);

        return outlierValue;
    }
}
