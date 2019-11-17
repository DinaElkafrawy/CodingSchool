using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game01 : MonoBehaviour
{
    bool first=false;
    bool second=false;
    bool third=false;
    bool fourth=false;
    bool fifth=false;
    bool sixth = false;
    public GameObject firstsphere;
    public GameObject secondsphere;
    public GameObject thirdsphere;
    public GameObject fourthsphere;
    public GameObject fifthsphere;
    public GameObject sixthsphere;
    public Button next;

    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        canvas.SetActive(false);
        next.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        if( (first == true ) && (second == true) && (third == true) && (fourth == true) && (fifth == true) && (sixth == true))
        {
            next.interactable = true;
        }
      
    }

   public void nextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Clickone() {
        Debug.Log("ONE");
        first = true;
        firstsphere.SetActive(false);
    }


    public void Clicktwo()
    {
        if (first == true)
        {
            second = true;
            secondsphere.SetActive(false);
        }
    }

    public void Clickthree()
    {
        if (first == true && second ==true)
        {
            third = true;
            thirdsphere.SetActive(false);
        }
    }
    public void Clickfourth()
    {
        if (first == true&&second==true&& third==true)
        {
            fourth = true;
            fourthsphere.SetActive(false);
        }
    }
    public void Clickfifth()
    {
        if (first == true && second == true && third == true && fourth==true)
        {
            fifth = true;
            fifthsphere.SetActive(false);
        }
    }
    public void ClickSixth()
    {
        if (first == true && second == true && third == true && fourth == true && fifth== true)
        {
            sixth = true;
            sixthsphere.SetActive(false);
            canvas.SetActive(true);

        }
    }
}
