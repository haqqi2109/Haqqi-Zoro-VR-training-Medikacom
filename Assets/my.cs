using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        // Mengambil input dari keyboard
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Membuat vektor gerakan
        Vector3 movement = new Vector3(horizontal, 0, vertical) * moveSpeed * Time.deltaTime;

        // Menggerakkan objek
        transform.Translate(movement);
    }
}
