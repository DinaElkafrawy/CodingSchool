using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataTypeExercise: MonoBehaviour
{
    private Vector3 mOffset;

    private float mZCoord;
    public GameObject clap;

    public AudioClip correct;
    public AudioClip wrong;
    public AudioClip clapping;
    int count;
    Button next;
    GameObject[] boolCubes;
    GameObject[] stringCubes;
    GameObject[] intCubes;
    GameObject[] floatCubes;

    void Start()
    {

        next = GameObject.Find("NextTask").GetComponent<UnityEngine.UI.Button>();
        count = 0;

        clap.GetComponent<AudioSource>().clip = clapping;
        
    }
    void OnMouseDown()
    {
        
        mZCoord = Camera.main.WorldToScreenPoint(
        gameObject.transform.position).z;

        // Store offset = gameobject world pos - mouse world pos
        mOffset = gameObject.transform.position - GetMouseAsWorldPoint();
    }

    void Update()
    {
        boolCubes = GameObject.FindGameObjectsWithTag("boolCube");
        stringCubes = GameObject.FindGameObjectsWithTag("stringCube");
        intCubes = GameObject.FindGameObjectsWithTag("intCube");
        floatCubes = GameObject.FindGameObjectsWithTag("floatCube");

        if ((intCubes.Length == 0) && (boolCubes.Length == 0) && (floatCubes.Length == 0))
        {
            Debug.Log("HAAAAAAA");

            if (stringCubes.Length == 0) { 
            Debug.Log("bool is empty");
            next.interactable = true;


            if (!clap.GetComponent<AudioSource>().isPlaying)
            {
                clap.GetComponent<AudioSource>().clip = clapping;
                clap.GetComponent<AudioSource>().Play();
            }
        }
        }
      
    }

    private Vector3 GetMouseAsWorldPoint()

    {
        // Pixel coordinates of mouse (x,y)
        Vector3 mousePoint = Input.mousePosition;

        // z coordinate of game object on screen
        mousePoint.z = mZCoord;

        // Convert it to world points

        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    void OnMouseDrag()

    {
        transform.position = GetMouseAsWorldPoint() + mOffset;
    }
    void OnTriggerEnter(Collider other)
    {
        next.interactable = false;
        if (gameObject.tag == "intCube" && other.gameObject.tag == "int")
        {
            count++;
            other.gameObject.GetComponent<AudioSource>().clip = correct;
            other.gameObject.GetComponent<AudioSource>().Play();
            Destroy(gameObject);
            
        }
        if (gameObject.tag == "floatCube" && other.gameObject.tag == "float")
        {
            count++;
            other.gameObject.GetComponent<AudioSource>().clip = correct;
            other.gameObject.GetComponent<AudioSource>().Play();
            Destroy(gameObject);
        }
        if (gameObject.tag == "stringCube" && other.gameObject.tag == "string")
        {
            count++;
            other.gameObject.GetComponent<AudioSource>().clip = correct;
            other.gameObject.GetComponent<AudioSource>().Play();
            Destroy(gameObject);
        }
        if (gameObject.tag == "boolCube" && other.gameObject.tag == "bool")
        {
            count++;
            other.gameObject.GetComponent<AudioSource>().clip = correct;
            other.gameObject.GetComponent<AudioSource>().Play();
            Destroy(gameObject);
        }
        else
        {
            gameObject.GetComponent<AudioSource>().clip = wrong;
            gameObject.GetComponent<AudioSource>().Play();
        }
        
     
    }



}
