using UnityEngine;
using System.Collections.Generic;
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
  // Upadates


  void Start()
  {
    myrigidbody = GetComponent<Rigidbody>();
    myCharacterController = GetComponent<CharacterController>();
    myAnimator = GetComponent<Animator>();
  }

  private void Update()
  {
    direction.z = speed;




    if (Input.GetKeyDown(KeyCode.UpArrow))
    {
      if (myCharacterController.isGrounded)
      {

        Jump();

        //myAnimator.SetBool("isJumping", true);
        myAnimator.Play("Jump");


      }
    }
    else
    {
      direction.y += gravity * Time.deltaTime;

    }

    if (Input.GetKeyDown(KeyCode.DownArrow))
      if (myCharacterController.isGrounded)
      {
        {
          myAnimator.Play("Roll");
        }



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
    myCharacterController.Move(direction * Time.fixedDeltaTime);

    myrigidbody.Sleep();

  }

  private void Roll()
  {


  }
  private void MovePlayer(Vector3 direction)
  {


    myCharacterController.Move(direction * horizontalspeed * Time.deltaTime);


  }

}
