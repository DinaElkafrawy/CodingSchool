using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class Validator : MonoBehaviour
{
    public GameObject text;

    public GameObject redlight;

    public GameObject Car;

    private CarController script;
    // Start is called before the first frame update
    void Start()
    {
        script = Car.GetComponent<CarController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (redlight.activeSelf)
        {
            if((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S)))
                text.SetActive(true);
            script.m_TractionControl = 0;
            script.m_ReverseTorque = 0;
            script.m_Topspeed = 0;
            Car.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            Car.GetComponent<Rigidbody>().isKinematic = true;


        }
        else
        {
            text.SetActive(false);
            script.m_TractionControl = 0.7f;
            script.m_ReverseTorque = 2000.0f;
            script.m_Topspeed = 2.0f;
            Car.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            Car.GetComponent<Rigidbody>().isKinematic = false;



        }
      
            
        
    }
}
