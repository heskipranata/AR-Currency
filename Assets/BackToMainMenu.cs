using UnityEngine;
using UnityEngine.SceneManagement; // Agar bisa mengakses scene management

public class BackToMainMenu : MonoBehaviour
{
    // Fungsi untuk kembali ke Main Menu
    public void LoadMainMenu()
    {
        // Pastikan nama scene yang dituju sudah sesuai, misalnya "MainMenu"
        SceneManager.LoadScene("MenuScene");
    }
}
