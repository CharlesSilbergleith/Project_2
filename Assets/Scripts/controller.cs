using UnityEngine;

public class Controller : MonoBehaviour
{
    //create a refrance to the Pawn object 
    public Pawn pawn;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("Application Quit!");
        }
        //calls the function every frame to see what the inputs are
        makeDesisions();
    }

    private void makeDesisions() {
        //ever frame this is called to check what is being pressed

        if (Input.GetKeyDown(pawn.inputkey)) {
            pawn.RandomTp(pawn.randomRangeX1, pawn.randomRangeX2, pawn.randomRangeY1, pawn.randomRangeY2);
        }



            //teleport up by a distense set by desighners 
            if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            pawn.teleportUp(pawn.teleportDistense);
        }

        //teleport down by a distense set by desighners 
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            pawn.teleportDown(pawn.teleportDistense);
        }

        //teleport right by a distense set by desighners 
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            pawn.teleportRight(pawn.teleportDistense);
        }
        //teleport left by a distense set by desighners 

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            pawn.teleportLeft(pawn.teleportDistense);
        }



        //checks if shift is pressed for turbo speed
        //checks if right OR left is pressed 
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {

            //speed is set to the sprint speed that is set by desighners in the pawn 
            if (Input.GetKey(KeyCode.W))
            {
                pawn.moveForward(pawn.sprintSpeed);
            }
            if (Input.GetKey(KeyCode.S))
            {
                pawn.moveBackward(pawn.sprintSpeed);

            }
        }
        else
        {
            //else if shit is not pressed 
            // normal speed also set by desighers in the pawn 
            if (Input.GetKey(KeyCode.W))
            {
                pawn.moveForward(pawn.moveSpeed);
            }
            if (Input.GetKey(KeyCode.S))
            {
                pawn.moveBackward(pawn.moveSpeed);

            }
           
        }

        // turning 
        // turn speed is set in the pawn
        // not included in the if above becouse it is just the speed at which it is turning,
            if (Input.GetKey(KeyCode.A))
            {
                pawn.turnLeft(pawn.rotateValue);
            }
            if (Input.GetKey(KeyCode.D))
            {
                pawn.turnRight(pawn.rotateValue);
            }
      
    }
}
