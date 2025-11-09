using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Health health;
    public Death death;
    //public AudioClip explosion;
    public AudioSource audioSource;
    public int randomRangeX1;
    public int randomRangeY1;
    public int randomRangeX2;
    public int randomRangeY2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake() { 
         health = GetComponent<Health>();
        death = GetComponent<Death>();
        health.currentHealth = 10;

    }
    void Start()
    {

        Ran();
        transform.position = new Vector3(Random.Range(randomRangeX1, randomRangeX2), Random.Range(randomRangeY1, randomRangeY2), 0);
        audioSource = GetComponent<AudioSource>();
        if (transform.position.x > 11f || transform.position.x < -11f)
        {

            transform.position = new Vector3(transform.position.x * -1, transform.position.y, transform.position.z);
        }
        if (transform.position.y > 6f || transform.position.y < -6f)
        {

            transform.position = new Vector3(transform.position.x, transform.position.y * -1, transform.position.z);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Ran() {
        transform.position = new Vector3(Random.Range(randomRangeX1, randomRangeX2), Random.Range(randomRangeY1, randomRangeY2), 0);

    }
  
}
