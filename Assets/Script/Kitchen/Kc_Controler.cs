using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Kc_Controler : MonoBehaviour
{
    public GameObject[] Halaman;

    public void ToHal1()
    {
        Halaman[0].SetActive(true);
        Halaman[1].SetActive(false);
    }

    public void ToHal2()
    {
        Halaman[1].SetActive(true);
        Halaman[0].SetActive(false);
    }
}
