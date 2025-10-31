using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Health health;
    public Death death;
    //public AudioClip explosion;
    public AudioSource audioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = GetComponent<Health>();
        death = GetComponent<Death>();
        GameManger.Instance.numOfEnemy ++;
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
