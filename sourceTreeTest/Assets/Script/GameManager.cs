using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public bool gameover;

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
        gameover = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startGame()
    {
        UI.instance.GameStart();
        ScoreManager.instance.startScore();
        GameObject.Find("planformspawnpos").GetComponent<PlaneformSpawner>().StartPlanespawn();
    }
   public void stopGame()
    {
        UI.instance.GameOver();
        ScoreManager.instance.stopScore();
        gameover = true;
    }
}
