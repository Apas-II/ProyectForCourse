using UnityEngine;

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

  // Upadates


  void Start()
  {
    myrigidbody = GetComponent<Rigidbody>();
    myCharacterController = GetComponent<CharacterController>();

  }

  private void Update()
  {
    direction.z = speed;
    if (myCharacterController.isGrounded)
    {


      if (Input.GetKeyDown(KeyCode.UpArrow))
      {

        Jump();
      }
    }
    else
    {
      direction.y += gravity * Time.deltaTime;

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


  private void MovePlayer(Vector3 direction)
  {


    myCharacterController.Move(direction * horizontalspeed * Time.deltaTime);


  }

}
