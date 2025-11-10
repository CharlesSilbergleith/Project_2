using UnityEngine;

public class UFO : Enemy
{
    public Transform pawn;
    public float MoveSpeed = 3f;
    public float rotateSpeed = 720f; // deg/sec
    public float angleOffset = -90f; // adjust so sprite points toward pawn visually


    void Start()
    {
        base.Ran();
        if (pawn == null)
        {
            GameObject pawnObj = GameObject.Find("Pawn");
            if (pawnObj != null)
                pawn = pawnObj.transform;
        }
    }

    void Update()
    {
        if (pawn == null) return;

        // --- Movement: go directly toward pawn position ---
        transform.position = Vector2.MoveTowards(transform.position, pawn.position, MoveSpeed * Time.deltaTime);

        // --- Rotation (for visuals): face pawn ---
        Vector2 dir = pawn.position - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg + angleOffset;
        Quaternion target = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, target, rotateSpeed * Time.deltaTime);
        if (transform.position.x > GameManger.Instance.maxX + 1 || transform.position.x < GameManger.Instance.minX - 1)
        {

            transform.position = new Vector3(transform.position.x * -1, transform.position.y, transform.position.z);
        }
        if (transform.position.y > GameManger.Instance.maxY + 1 || transform.position.y < GameManger.Instance.minY - 1)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y * -1, transform.position.z);

        }


    }

}
