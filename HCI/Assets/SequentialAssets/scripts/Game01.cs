using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game01 : MonoBehaviour
{
    public AudioClip right;
    public AudioClip wrong;
    private AudioSource sound;
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
        sound = GetComponent<AudioSource>();
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
        sound.clip = right;
        sound.Play();
        first = true;
        firstsphere.SetActive(false);
    }


    public void Clicktwo()
    {
        if (first == true)
        {
            sound.clip = right;
            sound.Play();
            second = true;
            secondsphere.SetActive(false);
        }
        else {
            sound.clip = wrong;
            sound.Play();
        }
    }

    public void Clickthree()
    {
        if (first == true && second ==true)
        {
            sound.clip = right;
            sound.Play();
            third = true;
            thirdsphere.SetActive(false);
        }
        else
        {
            sound.clip = wrong;
            sound.Play();
        }
    }
    public void Clickfourth()
    {
        if (first == true&&second==true&& third==true)
        {
            sound.clip = right;
            sound.Play();
            fourth = true;
            fourthsphere.SetActive(false);
        }
        else
        {
            sound.clip = wrong;
            sound.Play();
        }
    }
    public void Clickfifth()
    {
        if (first == true && second == true && third == true && fourth==true)
        {
            sound.clip = right;
            sound.Play();
            fifth = true;
            fifthsphere.SetActive(false);
        }
        else
        {
            sound.clip = wrong;
            sound.Play();
        }
    }
    public void ClickSixth()
    {
        if (first == true && second == true && third == true && fourth == true && fifth== true)
        {
            sound.clip = right;
            sound.Play();
            sixth = true;
            sixthsphere.SetActive(false);
            canvas.SetActive(true);

        }
        else
        {
            sound.clip = wrong;
            sound.Play();
        }
    }
}
