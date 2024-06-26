using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BuahBuah : MonoBehaviour
{
    public string NamaBuah;
    [Header("Texts")]
    public TextMeshProUGUI TextBuah;
    public GameObject Panel;

    private void Start()
    {
        TextBuah.text = NamaBuah;
    }

    public void OpenPanel()
    {
        Panel.SetActive(true);
    }
    public void ClosePanel()
    {
        Panel.SetActive(false);
    }
}
