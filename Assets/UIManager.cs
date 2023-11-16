using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject menu, settins;
    public void OpenMenu()
    {
        menu.SetActive(true);
        settins.SetActive(false);
    }

    public void OpenSettings()
    {
        menu.SetActive(false);
        settins.SetActive(true);
    }

}
