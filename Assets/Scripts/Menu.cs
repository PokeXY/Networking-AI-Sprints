using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public string menuName;
    //[HideInInspector] hide open option when its not in use
    public bool open;

    public void Open()
    {
        open = true;
        gameObject.SetActive(true);

    }

    public void Close()
    {
        open = false;
        gameObject.SetActive(false);
    }

}
