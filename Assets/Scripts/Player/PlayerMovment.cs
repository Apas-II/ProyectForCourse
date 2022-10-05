using UnityEngine;
using System.Collections.Generic;
using System.Collections;



public class PlayerMovment : MonoBehaviour
{
  /// VARIABLES ///
  private Vector3 direction;
  [SerializeField]
  private float speed = 12f;
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
  private bool isDeadanim = false;
  private bool isKnockBackAllow = false;
  /// Upadates ///


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

    if (isDeadanim == true)
    {
      if (isKnockBackAllow == false)
      {
        Knockback();
      }
    }

  }




  /// METODOS ///



  private void Jump()
  {
    direction.y = jumpForce;
  }



  // Movimiento hacia adelante
  private void FixedUpdate()
  {
    if (isRuningBool == true)
    {
      myCharacterController.Move(direction * Time.fixedDeltaTime);


    }
  }

  // Movimiento a los costados
  private void MovePlayer(Vector3 direction)
  {

    if (isRuningBool == true)
    {

      myCharacterController.Move(direction * horizontalspeed * Time.deltaTime);

    }
  }


  public void onHitManagger()
  {
    isRuningBool = false;
    isDeadanim = true;

    myAnimator.Play("Death");
    StartCoroutine(CountDownKnockBack());
  }


  public void onVictory()
  {
    myAnimator.Play("Victory");
    isRuningBool = false;
    isKnockBackAllow = true;



  }


  // Corutina del cominezo del juego. Idle
  IEnumerator Countdown(int seconds)
  {
    int count = seconds;

    while (count > 0)
    {


      yield return new WaitForSeconds(1.4f);
      count--;
    }
    myAnimator.SetFloat("isCrowching", 3f);
    isRuningBool = true;
    isDeadanim = false;

  }



  private void Knockback()
  {

    myCharacterController.Move(Vector3.back * Time.deltaTime * 3);
  }

  // corutina para que espere el tiempo de la animacion de hit y se active otra vez el isRuningBool
  IEnumerator CountDownKnockBack()
  {


    yield return new WaitForSeconds(3f);
    isRuningBool = true;



  }

  // tengo que parar la animacion de  runing. para que el pj quede quito y haga la animacion de victoria.


}

// arreglar el isRuningBool. ponerlo como un parametro del animator?


// agregar una variable bool  y despues hacer el death animation y el transform en el Update dependiende ese true or false. el KnockBack?

// hacer menu UI con tres niveles y un Exit game. Hacer un pause menu con un continue y un back to menu. 
// si gameover, back to menu. 