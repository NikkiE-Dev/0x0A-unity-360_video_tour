using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary>Activating correct game object that contains hotspots</summary>
public class TextManager : MonoBehaviour
{
    public GameObject TextBox;
    // Toggles showing and hiding of text box
    public void ActivateTextBox()
    {
        if (TextBox.activeInHierarchy == false)
        {
            TextBox.SetActive(true);
        }
        else
        {
            TextBox.SetActive(false);
        }
    }
}