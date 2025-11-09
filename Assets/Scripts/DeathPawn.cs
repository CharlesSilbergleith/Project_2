using UnityEngine;

public class DeathPawn : Death
{
    public Pawn pawn;
    public override void Die() {
        GameManger.Instance.lives -= 1;
        pawn.zero();
    }
}
