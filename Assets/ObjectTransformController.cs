using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotationSpeed = 70.0f; // Kecepatan rotasi
    private Vector3 initialRotation;    // Rotasi awal objek
    private bool isRotating = false;    // Apakah sedang dirotasi

    private void Start()
    {
        // Simpan rotasi awal objek
        initialRotation = transform.rotation.eulerAngles;
    }

    private void Update()
    {
        // Cek apakah ada sentuhan
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                // Hitung rotasi berdasarkan input sentuhan
                float rotationX = touch.deltaPosition.y * rotationSpeed * Time.deltaTime;
                float rotationY = -touch.deltaPosition.x * rotationSpeed * Time.deltaTime;

                // Terapkan rotasi pada objek
                transform.Rotate(rotationX, rotationY, 0, Space.World);

                isRotating = true;
            }
        }
        else if (Input.touchCount == 0 && isRotating)
        {
            // Hentikan rotasi ketika sentuhan berhenti
            isRotating = false;
        }
    }

    // Fungsi untuk mereset rotasi objek
    public void ResetRotation()
    {
        transform.rotation = Quaternion.Euler(initialRotation);
    }
}
