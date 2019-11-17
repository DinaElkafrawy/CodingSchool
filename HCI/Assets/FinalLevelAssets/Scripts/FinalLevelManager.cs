using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalLevelManager : MonoBehaviour
{
    [SerializeField] private GameObject playPanel;
    [SerializeField] private GameObject codeSnippet;
    [SerializeField] private GameObject showCodeButton;
    [SerializeField] private AudioSource buzzer;
    [SerializeField] private GameObject cubes;
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private Text scoreText;

    private bool showCode = false;
    private float codeTime = 5f;
    private float codeTimer;
    private float playTime = 30f;
    public int boxes = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (showCode && codeTimer > 0)
            codeTimer -= Time.deltaTime;

        if (showCode && codeTimer <= 0)
        {
            codeSnippet.SetActive(false);
            showCode = false;
            showCodeButton.SetActive(true);
        }

        if (playTime > 0)
            playTime -= Time.deltaTime;
        else
            EndGame();
    }

    public void Play()
    {
        playPanel.SetActive(false);
        codeSnippet.SetActive(true);
        showCode = true;
        codeTimer = codeTime;
        buzzer.Play();
    }

    public void activateCode()
    {
        showCodeButton.SetActive(false);
        codeSnippet.SetActive(true);
        showCode = true;
        codeTimer = codeTime;
    }

    public void EndGame()
    {
        buzzer.Stop();
        cubes.SetActive(false);
        showCodeButton.SetActive(false);
        codeSnippet.SetActive(false);
        scoreText.text = "Score: " + boxes + "/10"; 
        gameOverPanel.SetActive(true);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
