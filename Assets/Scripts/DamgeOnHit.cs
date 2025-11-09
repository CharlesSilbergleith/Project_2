using UnityEngine;

public class DamgeOnHit : MonoBehaviour
{
    public bool InstaDeath;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other) {
        Health otherHealth = other.gameObject.GetComponent<Health>();
        Pawn    otherPawn = other.gameObject.GetComponent<Pawn>();
        UFO otherUFO = other.gameObject.GetComponent<UFO>();
        if (InstaDeath)
        {
            if (otherHealth != null && otherPawn != null )
            {
                otherHealth.TakeDamage(otherHealth.maxHealth);
            }
        }
        else
        {
            //Health otherHealth = other.gameObject.GetComponent<Health>();
            if (otherHealth != null && otherPawn != null)
            {
                otherHealth.TakeDamage(1);
            }
        }
        


    }




}
