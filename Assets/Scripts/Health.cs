using JetBrains.Annotations;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float currentHealth;
    public float maxHealth;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //take damage function
    public void TakeDamage(float damage) { 
        currentHealth-= damage;
        if (!IsAlive()) {
            currentHealth = 0;
            Die();
        }

        }
    //heal
    public void Heal(float amount) {
        currentHealth += amount;
        if (currentHealth > maxHealth) {
            currentHealth = maxHealth;
        }
    
    }
    public void Die() { 
        //get death
        Death death = GetComponent<Death>();
        //check death
        if (death != null) { 
            //die
            death.Die();
        }
    }

    //check if alive
    public bool IsAlive()
    {
        if (currentHealth > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    

}
