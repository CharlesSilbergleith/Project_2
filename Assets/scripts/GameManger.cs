using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManger : MonoBehaviour
{
    public static GameManger Instance;
    public Controller controller;
    public Pawn pawn;
    public GameObject BigAstroid;
    public GameObject UFO;
    public GameObject LittleAstroid;
    public int numOfEnemy;
    public float score;
    public Health PawnHealth;
    public UIManger UI;
    public float lives;
    private int astroidOrNot;
    public float timeTillLeave = 4f;
    private bool win;
    public int maxX;
    public int maxY;
    public int minX;   
    public int minY;
    public int chanceMax;
    public int chanceMin;
    public int chanceOfAstroid;


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
        for (int i = numOfEnemy; i > 0; i--) {
            astroidOrNot = Random.Range(chanceMax, chanceMin);
            if (astroidOrNot <= chanceOfAstroid) {
                Instantiate(BigAstroid);
            }
            else
            {
                Instantiate(UFO);
            }
        }
        lives = 3;
        
       
}


    void Start()
    {
        UI.ScreenUpdate();
        

    }

    // Update is called once per frame
    void Update()
    {
        if (numOfEnemy == 0) {
            gameWin();
            gameEnd();
        }
        if (lives <= 0) {
            gameLose();
            gameEnd();
        }
        if (pawn == null) { 
            Instantiate(pawn, Vector3.zero, Quaternion.identity);
            
        }

        
    }
    public void gameEnd()
    {
        
        StartCoroutine(LoadNextSceneAfterDelay(3f));
    }

    private IEnumerator LoadNextSceneAfterDelay(float delay)
    {
        // Optional: pause the game
        Time.timeScale = 0f;

        // Wait 3 real seconds (unaffected by pause)
        yield return new WaitForSecondsRealtime(delay);

        // Restore normal time before switching scenes
        Time.timeScale = 1f;

        // Load next scene
        if (!win)
        {
            SceneManager.LoadScene("MainMenu");
        }
        else { 
            SceneManager.LoadScene("playWorld");
        }

           
    }

    void gameWin() {
        UIManger.Instance.Win.enabled = true;
        win = true;
        
        //Debug.Log("You WIn good job..... reword...... what wining not enough.... greedy");
    }
    public void gameLose() {
        UIManger.Instance.Die.enabled = true;
        win = false;
        //Debug.Log("HA you suck... like holy shit that was bad..... do better");
        score = 0;
        lives = 3;

    }
    public void reset() { 
        score = 0;
    }
    public void scorePlus() {
        score++;
        UI.ScreenUpdate();
    }
    public void scorePlus(int value)
    {
        score+= value;
        UI.ScreenUpdate();
    }

}
