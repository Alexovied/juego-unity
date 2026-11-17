using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    public float velocidad = 5f;
    public float fuerzaSalto = 6f;
    Rigidbody rb;

    void Awake() => rb = GetComponent<Rigidbody>();

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(h, 0, v) * velocidad * Time.deltaTime);

        if (Input.GetButtonDown("Jump"))
            rb.AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);
    }
}
