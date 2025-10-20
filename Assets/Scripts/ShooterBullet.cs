using UnityEngine;

public class ShooterBullet : shooter
{
    public float ShootSpeed;
    public float damage;
    // Start is called once be  fore the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        shoot();


    }
    void OnTriggerEnter2D(Collider2D other) {
        Health otherHealth = other.gameObject.GetComponent<Health>();
            //Health otherHealth = other.gameObject.GetComponent<Health>();
            if (otherHealth != null)
            {
                otherHealth.TakeDamage(damage);
            }
        Destroy(gameObject);
    }


  
    void OnBecameInvisible()
     {
            Destroy(gameObject);
     }


    public override void shoot() {
        if (this != null)
        {
            transform.position += (transform.up * ShootSpeed * Time.deltaTime);
        }
    }
    
}
