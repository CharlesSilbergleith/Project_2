using UnityEngine;
using UnityEngine.UI;


public class EnemyHealth : Health
{
    
    [SerializeField] private Slider healthBar;

    void awake()
    {
        healthBar = GetComponentInChildren<Slider>();

    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
     public override void TakeDamage(float damage)
    {
        base.TakeDamage(damage);
        healthBar.value = healthPercent;



       
    }
     public override void TakeDamage()
    {

        base.TakeDamage();
        healthBar.value = healthPercent;




        
    }

}
