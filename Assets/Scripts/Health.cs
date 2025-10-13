using JetBrains.Annotations;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float currentHealth;
    public float maxHealth;
    public SpriteRenderer spriteRenderer;
    public float healthPercent;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      healthPercent = currentHealth / maxHealth;
     Color newColor = new Color(1f, healthPercent, healthPercent, 1f);
     spriteRenderer.color = newColor;
    }

    //take damage function
    public void TakeDamage(float damage)
    {
        currentHealth -= damage;


       
        
        if (!IsAlive())
        {
            currentHealth = 0;
            Die();
        }
    }
    public void TakeDamage() {
        currentHealth -= 5;




        if (!IsAlive())
        {
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
            death.finalWords();
            Heal(maxHealth);
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
