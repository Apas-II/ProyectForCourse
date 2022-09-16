using UnityEngine;
using System.Collections.Generic;
using System.Collections;

// CON ESTE SCRIPT MUEVO EL PJ, SETEO LAS ANIMACIONES Y ADECUO EL COLIDDER A LAS ANIMACIONES//

public class PlayerMovment : MonoBehaviour
{
  /// Variables 
  private Vector3 direction;
  [SerializeField]
  private float speed = 7.0f;
  private CharacterController myCharacterController;
  [SerializeField]
  private float jumpForce = 10f;
  [SerializeField]
  private float gravity = -20f;
  [SerializeField]
  private float horizontalspeed = -20f;
  private Rigidbody myrigidbody;
  private Animator myAnimator;
  [SerializeField]
  private bool isRuningBool = false;
  // Upadates


  void Start()
  {
    myrigidbody = GetComponent<Rigidbody>();
    myCharacterController = GetComponent<CharacterController>();
    myAnimator = GetComponent<Animator>();
    StartCoroutine(Countdown(3));
  }



  private void Update()
  {
    direction.z = speed;



    if (Input.GetKeyDown(KeyCode.UpArrow))
    {
      if (myCharacterController.isGrounded)
      {


        Jump();
        myAnimator.SetBool("isJumping", true);


      }
    }
    else
    {
      direction.y += gravity * Time.deltaTime;
      myAnimator.SetBool("isJumping", false);

    }


    if (Input.GetKeyDown(KeyCode.DownArrow))
    {
      if (myCharacterController.isGrounded)
      {
        {
          myAnimator.SetBool("isRolling", true);

        }
      }

    }
    else
    {
      myAnimator.SetBool("isRolling", false);
    }




    if (Input.GetKey(KeyCode.RightArrow))
    {
      MovePlayer(Vector3.left);

    }
    if (Input.GetKey(KeyCode.LeftArrow))
    {
      MovePlayer(Vector3.right);

    }


    if (Input.GetKey(KeyCode.P))
    {
      deletearinventario();

    }


  }

  // Metodos

  private void deletearinventario()
  {

    GameManager.Instance.inventory.Clear();

  }


  private void Jump()
  {
    direction.y = jumpForce;
  }

  private void FixedUpdate()
  {
    if (isRuningBool == true)
    {
      myCharacterController.Move(direction * Time.fixedDeltaTime);

      myrigidbody.Sleep();
    }
  }


  private void MovePlayer(Vector3 direction)
  {

    if (isRuningBool == true)
    {

      myCharacterController.Move(direction * horizontalspeed * Time.deltaTime);

    }
  }



  public void onVictory()
  {

    isRuningBool = false;
    myAnimator.Play("Victory");


  }


  IEnumerator Countdown(int seconds)
  {
    int count = seconds;

    while (count > 0)
    {

      // display something...
      yield return new WaitForSeconds(1.4f);
      count--;
    }
    myAnimator.SetFloat("isCrowching", 3f);
    isRuningBool = true;

  }


  // tengo que parar la animacion de  runing. para que el pj quede quito y haga la animacion de victoria.


}
