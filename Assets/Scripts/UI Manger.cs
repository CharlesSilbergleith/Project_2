using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManger : MonoBehaviour
{
    public Image health;
    public TMP_Text score;
    public TMP_Text ammo;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameManger.Instance.reset();
        score.text = " Score ";
        ammo.text = " Score ";
    }

    // Update is called once per frame
    void Update()
    {
        
        ammo.text = "Ammo: " + GameManger.Instance.pawn.ammo + "/" + GameManger.Instance.pawn.ammoMax;
        health.fillAmount = GameManger.Instance.PawnHealth.currentHealth*.1f;
    }
    public void scoreUpdate() {
        score.text = "Score: " + GameManger.Instance.score;
    }
}
