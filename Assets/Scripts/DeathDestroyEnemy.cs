using UnityEngine;

public class DeathDestroyEnemy : DeathDestroy
{
    public override void Die()
    {
        GameManger.Instance.scorePlus();
        //destroy the game object that this script is on
        base.Die();
        
    }

}
