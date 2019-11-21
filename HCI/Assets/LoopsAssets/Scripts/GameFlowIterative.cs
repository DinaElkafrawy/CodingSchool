using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameFlowIterative : MonoBehaviour
{
    private AudioSource sound;
    public AudioClip end;
    public GameObject s5;
    public GameObject s4;
    public AudioClip click;
    public AudioClip destroy;
    public Button next;
    public GameObject s3;
    public GameObject s2;
    public GameObject s1;
    int counterone = 1;
    int countertwo = 2;
    int counterthree = 3;
    int counterfour = 4;
    int counterfifth = 5;
    public Text fiveText;
    public Text fourText;

    public Text threeText;
    public Text twoText;
    public Text oneText;
    public GameObject done;
    public Text endgame;
    bool endd = false;
    // Start is called before the first frame update
    void Start()
    {
        sound = GetComponent<AudioSource>();
        done.SetActive(false);
        fiveText.text = counterfifth.ToString();
        fourText.text = counterfour.ToString();
        threeText.text = counterthree.ToString();
        twoText.text = countertwo.ToString();
        oneText.text = counterone.ToString();
        next.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (counterone == 0 && countertwo == 0 && counterthree == 0 && counterfour == 0 && counterfifth == 0)
        {
            //done.SetActive(true);
            endgame.text = "Congratulations on passing the while loops !! Now while the challenges are not finished keep playing ;) ";
            endd = true;
            next.interactable = true;
            playend();
        }
    }

    public void NextEx()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void playend()
    {
        if (endd)
        {
            sound.PlayOneShot(end);
            endd = false;
        }
    }
   public void spherefive()
    {
        sound.PlayOneShot(click);
        counterfifth--;
        fiveText.text = counterfifth.ToString();
        if (counterfifth == 0)
        {
            sound.PlayOneShot(destroy);

            Destroy(s5);
        }
    }
    public void spherefour()
    {
        sound.PlayOneShot(click);

        counterfour--;
        fourText.text = counterfour.ToString();
        if (counterfour == 0)
        {
            sound.PlayOneShot(destroy);
            Destroy(s4);
        }
    }
    public void spherethree()
    {
        sound.PlayOneShot(click);

        counterthree--;
        threeText.text = counterthree.ToString();
        if (counterthree == 0)
        {
            sound.PlayOneShot(destroy);

            Destroy(s3);
        }
    }

    public void spheretwo()
    {
        sound.PlayOneShot(click);

        countertwo--;
        twoText.text = countertwo.ToString();
        if (countertwo == 0)
        {
            sound.PlayOneShot(destroy);

            Destroy(s2);
        }
    }
    public void sphereone()
    {
        sound.PlayOneShot(click);

        counterone--;
        oneText.text = counterone.ToString();
        if (counterone == 0)
        {
            sound.PlayOneShot(destroy);

            Destroy(s1);
        }
    }

}
