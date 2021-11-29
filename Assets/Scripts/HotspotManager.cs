using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

///<summary>Activating correct game object that contains hotspots</summary>
public class HotspotManager : MonoBehaviour
{
    public GameObject LivingRoom;
    public GameObject Cube;
    public GameObject Cantina;
    public GameObject Mezzanine;

    public void OpenLivingRoom()
    {
        Cube.SetActive(false);
        Cantina.SetActive(false);
        Mezzanine.SetActive(false);
        LivingRoom.SetActive(true);
    }

    public void OpenCube()
    {
        LivingRoom.SetActive(false);
        Cantina.SetActive(false);
        Mezzanine.SetActive(false);
        Cube.SetActive(true);
    }

    public void OpenCantina()
    {
        LivingRoom.SetActive(false);
        Cube.SetActive(false);
        Mezzanine.SetActive(false);
        Cantina.SetActive(true);
    }

    public void OpenMezzanine()
    {
        LivingRoom.SetActive(false);
        Cube.SetActive(false);
        Cantina.SetActive(false);
        Mezzanine.SetActive(true);
    }
}