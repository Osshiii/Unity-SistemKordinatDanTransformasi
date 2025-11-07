using UnityEngine;

public class MoveInSpace : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float rotateSpeed = 90f;
    public bool useLocal = true; // sinkronkan manual dengan HUD (atau biarkan terpisah)

    void Update()
    {
        // Toggle mode dengan Tab (boleh sama seperti HUD atau kamu matikan di sini)
        if (Input.GetKeyDown(KeyCode.Tab))
            useLocal = !useLocal;

        Space sp = useLocal ? Space.Self : Space.World;

        // WASD untuk gerak
        float h = Input.GetAxis("Horizontal"); // A/D
        float v = Input.GetAxis("Vertical");   // W/S
        transform.Translate(new Vector3(h, 0f, v) * moveSpeed * Time.deltaTime, sp);

        // Q/E untuk rotasi sumbu Y
        if (Input.GetKey(KeyCode.Q)) transform.Rotate(Vector3.up, -rotateSpeed * Time.deltaTime, sp);
        if (Input.GetKey(KeyCode.E)) transform.Rotate(Vector3.up,  rotateSpeed * Time.deltaTime, sp);
    }
}
