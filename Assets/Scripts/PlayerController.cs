using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float moveSpeed = 5f;
	public float rotationSpeed = 5f;

	public float rotation;
	private Rigidbody rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
		rotation = 0;
	}

	void Update ()
	{

	}
	public void LeftButton()
	{
		rotation = -1f;

	}

	public void RightButton()
	{
		rotation = 1f;

	}

	void FixedUpdate ()
	{
		//rotation = rotation - 0.002f;
		rb.MovePosition(rb.position + transform.forward * moveSpeed * Time.fixedDeltaTime);
		Vector3 yRotation = Vector3.up * rotation * rotationSpeed * Time.fixedDeltaTime;
		Quaternion deltaRotation = Quaternion.Euler(yRotation);
		Quaternion targetRotation = rb.rotation * deltaRotation;
		rb.MoveRotation(Quaternion.Slerp(rb.rotation, targetRotation, 50f * Time.deltaTime));
		//transform.Rotate(0f, rotation * rotationSpeed * Time.fixedDeltaTime, 0f, Space.Self);
	}

	
}
