using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Health health;
    public Death death;
 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = GetComponent<Health>();
        death = GetComponent<Death>();
        GameManger.Instance.numOfEnemy ++;

    }

    // Update is called once per frame
    void Update()
    {

    }
}
