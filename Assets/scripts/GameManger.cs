using UnityEngine;

public class GameManger : MonoBehaviour
{
    public static GameManger Instance;
    public Controller controller;
    public Pawn pawn;
    public Enemy enemy;
    public int numOfEnemy;
    public int score;
    public Health PawnHealth;
    public Health EnemyHealth;
    public UIManger UI;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else {
            Destroy(gameObject);
        }

        numOfEnemy = 0;
}


    void Start()
    {
        UI.scoreUpdate();

    }

    // Update is called once per frame
    void Update()
    {
        if (enemy == null) {
            gameWin();
            gameEnd();
        }
        if (pawn == null) {
            gameLose();
            gameEnd();
        }
        
    }
    void gameEnd() {
        Debug.Log("leave game");
        
    }
    void gameWin() {
        Debug.Log("You WIn good job..... reword...... what wining not enough.... greedy");
    }
    public void gameLose() {
        Debug.Log("HA you suck... like holy shit that was bad..... do better");
    
    }
    public void reset() { 
        score = 0;
    }
    public void scorePlus() {
        score++;
        UI.scoreUpdate();
    }
    public void scorePlus(int value)
    {
        score+= value;
        UI.scoreUpdate();
    }

}
