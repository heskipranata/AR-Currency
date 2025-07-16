using UnityEngine;
using TMPro;

public class CurrencyInfoPanel : MonoBehaviour
{
    // Panel terpisah untuk setiap informasi
    public GameObject panel1; // Panel untuk Nama Negara
    public GameObject panel2; // Panel untuk Nama Mata Uang
    public GameObject panel3; // Panel untuk Kode ISO dan Simbol Mata Uang
    public GameObject panel4; // Panel untuk Informasi Singkat
    public GameObject panel5; // Panel untuk Nilai Tukar
    public GameObject panel6; // Panel untuk Pecahan Mata Uang

    // Referensi TextMeshPro untuk masing-masing panel
    public TextMeshProUGUI countryNameText;     // Teks untuk Nama Negara
    public TextMeshProUGUI currencyNameText;    // Teks untuk Nama Mata Uang
    public TextMeshProUGUI isoAndCurrencySymbolText;       // Teks untuk Kode ISO
    public TextMeshProUGUI infoText;            // Teks untuk Informasi Singkat
    public TextMeshProUGUI exchangeRateText;    // Teks untuk Nilai Tukar
    public TextMeshProUGUI coinDenominationsText; // Teks untuk Pecahan Koin
    public TextMeshProUGUI noteDenominationsText; // Teks untuk Pecahan Uang Kertas

    void Start()
    {
        // Sembunyikan semua panel pada awal
        HideAllPanels();
    }

    // Fungsi untuk menampilkan informasi berdasarkan objek yang terdeteksi
    public void ShowInfo(
        string countryName, string currencyName, string isoAndCurrencySymbol,
        string info, string exchangeRate, string coinDenominations, string noteDenominations)
    {
        // Update konten setiap panel
        countryNameText.text = countryName;
        currencyNameText.text = currencyName;
        isoAndCurrencySymbolText.text = isoAndCurrencySymbol;
        infoText.text = info;
        exchangeRateText.text = exchangeRate;
        coinDenominationsText.text = coinDenominations;
        noteDenominationsText.text = noteDenominations;

        // Tampilkan semua panel
        panel1.SetActive(true);
        panel2.SetActive(true);
        panel3.SetActive(true);
        panel4.SetActive(true);
        panel5.SetActive(true);
        panel6.SetActive(true);
    }

    // Fungsi untuk menyembunyikan semua panel
    public void HideAllPanels()
    {
        panel1.SetActive(false);
        panel2.SetActive(false);
        panel3.SetActive(false);
        panel4.SetActive(false);
        panel5.SetActive(false);
        panel6.SetActive(false);
    }
}
