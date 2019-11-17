using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalLevelBox : MonoBehaviour
{
    [SerializeField] private FinalLevelManager manager;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (this.tag == other.gameObject.tag)
        {
            Destroy(other.gameObject);
            manager.boxes++;
            if (manager.boxes == 10)
            {
                manager.EndGame();
            }
        }

    }

    private void OnTriggerStay(Collider other)
    {
        FinalLevelCube cube = other.gameObject.GetComponent<FinalLevelCube>();

        if (this.tag != other.gameObject.tag)
            other.gameObject.GetComponent<Rigidbody>().AddForce(-0.1f, 0f, 0f);

    }
}
