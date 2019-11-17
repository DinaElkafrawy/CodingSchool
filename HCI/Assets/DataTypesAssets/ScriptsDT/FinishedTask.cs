using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishedTask : MonoBehaviour
{
    public AudioClip clapping;
    public GameObject clap;

    GameObject[] boolCubes;
    GameObject[] stringCubes;
    GameObject[] intCubes;
    GameObject[] floatCubes;

    Button next;

    // Start is called before the first frame update
    void Start()
    {
        next = GameObject.Find("NextTask").GetComponent<UnityEngine.UI.Button>();
        clap.GetComponent<AudioSource>().clip = clapping;
    }

    // Update is called once per frame
    void Update()
    {
        boolCubes = GameObject.FindGameObjectsWithTag("boolCube");
        stringCubes = GameObject.FindGameObjectsWithTag("stringCube");
        intCubes = GameObject.FindGameObjectsWithTag("intCube");
        floatCubes = GameObject.FindGameObjectsWithTag("floatCube");

        if ((intCubes.Length == 0) && (boolCubes.Length == 0) && (floatCubes.Length == 0) && (stringCubes.Length == 0))
        {
            next.interactable = true;

            if (!clap.GetComponent<AudioSource>().isPlaying)
              {
                clap.GetComponent<AudioSource>().clip = clapping;
                clap.GetComponent<AudioSource>().Play();
              }
            }
    }

}
