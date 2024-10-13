using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class logic : MonoBehaviour
{

    public GameObject BALL;
    public int RightPlayerScore;
    public int LeftPlayerScore;
    public Text RightscoreText;
    public Text LeftscoreText;
    public AudioSource Pong;
    // Start is called before the first frame update
    void Start()
    {
        spawn();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void RightScore()
    {
        RightPlayerScore = RightPlayerScore + 1;
        RightscoreText.text = RightPlayerScore.ToString();
        Pong.Play();
        spawn();

    }
    public void LeftScore()
    {
        LeftPlayerScore = LeftPlayerScore + 1;
        LeftscoreText.text = LeftPlayerScore.ToString();
        Pong.Play();
        spawn();

    }
    void spawn() {
        Instantiate(BALL);
    }



}
