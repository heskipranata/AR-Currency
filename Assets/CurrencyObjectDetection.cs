using UnityEngine;

public class CurrencyObjectDetection : MonoBehaviour
{
    // Informasi mata uang untuk objek
    public string countryName;                // Nama negara
    public string currencyName;               // Nama mata uang
    public string isoAndCurrencySymbol;                  // Kode ISO mata uang (USD, EUR, dll.)

    public string info;                       // Info singkat tentang mata uang
    public string exchangeRate;               // Nilai tukar terhadap Rupiah
    public string coinDenominations;          // Pecahan koin (contoh: 1, 5, 10)
    public string noteDenominations;          // Pecahan uang kertas (contoh: 1000, 5000, 10000)

    public CurrencyInfoPanel infoPanelScript; // Referensi ke script panel info

    // Fungsi untuk memanggil info ketika objek terdeteksi
    public void OnObjectDetected()
    {
        Debug.Log("Object detected: " + countryName); 
        if (infoPanelScript != null)
        {
            infoPanelScript.ShowInfo(
                countryName,
                currencyName,
                isoAndCurrencySymbol,
                info,
                exchangeRate,
                coinDenominations,
                noteDenominations
            );
        }
    }

    // Fungsi untuk menyembunyikan info ketika objek hilang
     // Fungsi untuk menyembunyikan info ketika objek hilang
    public void OnObjectLost()
    {
        if (infoPanelScript != null)
        {
            infoPanelScript.HideAllPanels();  // Menyembunyikan semua panel
        }
    }
}
