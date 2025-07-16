using Vuforia;
using UnityEngine;

public class TargetStatusHandler : MonoBehaviour
{
    public CurrencyObjectDetection currencyObjectDetection;  // Referensi ke script CurrencyObjectDetection

    private ObserverBehaviour observerBehaviour;

    // Start is called before the first frame update
    void Start()
    {
        // Ambil komponen ObserverBehaviour dari GameObject
        observerBehaviour = GetComponent<ObserverBehaviour>();

        // Pastikan observerBehaviour terdaftar untuk menerima event status perubahan
        if (observerBehaviour != null)
        {
            observerBehaviour.OnTargetStatusChanged += OnTargetStatusChanged;
        }
        else
        {
            Debug.LogError("ObserverBehaviour tidak ditemukan pada objek ini!");
        }
    }

    // Fungsi untuk menangani perubahan status target
    private void OnTargetStatusChanged(ObserverBehaviour observer, TargetStatus status)
    {
        // Jika status target TRACKED (terdeteksi), panggil OnObjectDetected
        if (status.Status == Status.TRACKED)
        {
            Debug.Log("Target Detected!");
            currencyObjectDetection.OnObjectDetected();  // Menampilkan informasi objek
        }
        else
        {
            Debug.Log("Target Lost!");
            currencyObjectDetection.OnObjectLost();  // Menyembunyikan informasi objek
        }
    }

    // Jangan lupa untuk menghapus listener jika objek dihancurkan atau dinonaktifkan
    private void OnDestroy()
    {
        if (observerBehaviour != null)
        {
            observerBehaviour.OnTargetStatusChanged -= OnTargetStatusChanged;
        }
    }
}
