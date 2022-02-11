using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody rigidbody;
    private bool isGrounded;
    private Vector3 direction;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rigidbody.AddForce(Vector3.up * 5, ForceMode.Impulse);
        }

        isGrounded = Physics.Raycast(transform.position, -Vector3.up, 1.5f);
    }

    private void FixedUpdate()
    {
        rigidbody.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
    }
}