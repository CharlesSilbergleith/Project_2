using UnityEngine;

public class Pawn : MonoBehaviour
    
{
    [Header("panw")]
    public GameObject pawn;
    [Header("movment")]
    //the normal speed in which the pawn moves
    public float moveSpeed;

    //the speed in which the pawn rotates
    public float rotateValue;

    //turbo speed or i call it sprint speed,
    // speed that the pawn goes when shift is pressed
    public float sprintSpeed;

    // how far the teleport is going to go
    public float teleportDistense;


    // input key for random
    public KeyCode inputkey;

    //transform for random tp
    public Transform location;
    //public Vector2 spriteLocation;
    public int randomRangeX1;
    public int randomRangeY1;
    public int randomRangeX2;
    public int randomRangeY2;

    [Header("Componets")]
    public Health health;
    public Death death;
    [Header("Shooting")]
    
    public GameObject Bullet;
   
    



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = GetComponent<Health>();
        death = GetComponent<Death>();
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    //function called by the controller to move forward by a speed set by deginerns 
    //has the parameter of moveSpeed made in the pawn object
    public void moveForward( float moveSpeed) {
        transform.position +=(transform.up* moveSpeed* Time.deltaTime);
    }


    //function called by the controller to move backwards by a speed set by deginerns 
    //has the parameter of moveSpeed made in the pawn object
    public void moveBackward(float moveSpeed)
    {
        transform.position += (-transform.up * moveSpeed * Time.deltaTime);
    }


    //function called by the controller to turn left by a speed set by deginerns 
    //has the parameter of rotateValue made in the pawn object
    public void turnLeft(float rotateValue) {
        transform.Rotate(0.0f, 0.0f, rotateValue * Time.deltaTime);
    
    }


    //function called by the controller to turn right by a speed set by deginerns 
    //has the parameter of rotateValue made in the pawn object
    public void turnRight(float rotateValue)
    {
        transform.Rotate(0.0f, 0.0f,- rotateValue * Time.deltaTime);

    }


    //function called by the controller to teleport up by a speed set by deginerns 
    //has the parameter of teleportDistense made in the pawn object
    public void teleportUp( float teleportDistense) {
        transform.position+= Vector3.up * teleportDistense;
    }


    //function called by the controller to teleport down by a speed set by deginerns 
    //has the parameter of teleportDistense made in the pawn object

    public void teleportDown(float teleportDistense)
    {
        transform.position += Vector3.down * teleportDistense;
    }


    //function called by the controller to teleport left by a speed set by deginerns 
    //has the parameter of teleportDistense made in the pawn object

    public void teleportLeft(float teleportDistense)
    {
        transform.position += Vector3.left * teleportDistense;
    }


    //function called by the controller to teleport rigth by a speed set by deginerns 
    //has the parameter of teleportDistense made in the pawn object

    public void teleportRight(float teleportDistense)
    {
        transform.position += Vector3.right * teleportDistense;
    }

    public void RandomTp(float randomRangeX1, float randomRangeX2, float randomRangeY1, float randomRangeY2) {
        location.position = new Vector3(Random.Range(randomRangeX1, randomRangeX2), Random.Range(randomRangeY1, randomRangeY2), 0);
    }


    public void Shoot() {
        Instantiate(Bullet,pawn.transform.position + transform.up, pawn.transform.rotation);
        //Debug.Log("Shoot");
    }

    
  





}
