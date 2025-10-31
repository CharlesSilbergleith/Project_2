using UnityEngine;

public class DeathDestroyEnemy : DeathDestroy
{

    
    public override void Die()
    {
        GameManger.Instance.scorePlus();
        SFXManger.Instance.expload();
        //destroy the game object that this script is on
        base.Die();
        
    }

}
