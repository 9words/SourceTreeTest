using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public static UI instance;
    public GameObject zigzagPanel;
    public GameObject GameoverPanel;
    public GameObject tapText;
    public Text score;
    public Text highscore1;
    public Text highscore2;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        highscore1.text = "High Score: "+PlayerPrefs.GetInt("highScore");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  public  void GameStart()
    {
       
        tapText.SetActive(false);
        zigzagPanel.GetComponent<Animator>().Play("PanelUp");
        
    }
   public void GameOver()
    {

        GameoverPanel.SetActive(true);
        score.text = PlayerPrefs.GetInt("Score").ToString();
        highscore2.text = PlayerPrefs.GetInt("highScore").ToString();

    }
   public void Rest()
    {
        SceneManager.LoadScene(0);
    }
}
