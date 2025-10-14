using UnityEngine;

public class InstantiateTest : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject prefabtocopy;
    public Controller controllerToConnect;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.L)) {
            GameObject TempPawn;
            TempPawn =  Instantiate(prefabtocopy,Vector3.zero, Quaternion.identity) as GameObject ;
            Debug.Log("work");
            if (TempPawn != null) {
                Pawn pawnComponet = TempPawn.GetComponent<Pawn>();
                controllerToConnect.pawn = pawnComponet;
                }
            Health healthComponet = TempPawn.GetComponent<Health>();
            if (healthComponet != null) {
                healthComponet.maxHealth = 10;
            }
        }
        
    }
}
