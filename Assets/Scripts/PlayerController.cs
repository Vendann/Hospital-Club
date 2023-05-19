using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator animator;
	private Rigidbody rb;
	private float hInput;
	private float vInput;
	public float speed = 4f;
	public float rotationSpeed = 10f;
	private Vector3 directionVector;
	public int damage = 5;
	
    void Start()
    {
        rb = GetComponent<Rigidbody>();
		animator = GetComponent<Animator>();
    }

    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
		vInput = Input.GetAxis("Vertical");
		directionVector = new Vector3(hInput, 0, vInput);
		animator.SetFloat("speed", Vector3.ClampMagnitude(directionVector, 1).magnitude);
		if (directionVector.magnitude > Mathf.Abs(0.05f))
			transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(directionVector), Time.deltaTime * rotationSpeed);
		if (Input.GetMouseButton(0))
		{
			int i = Random.Range(1, 7);
			animator.Play(i.ToString());
		}
    }
	
	void FixedUpdate()
	{
		rb.velocity = Vector3.ClampMagnitude(directionVector, 1) * speed;
		rb.angularVelocity = Vector3.zero;
	}

    private void OnTriggerStay(Collider other)
    {
		if (Input.GetMouseButton(0))
		{
			if (other.tag == "Enemy")
				other.GetComponent<Enemy>().TakeDamage(damage);
		}
	}
}
