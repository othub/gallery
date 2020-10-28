using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VBInteraction : MonoBehaviour
{

    VirtualButtonBehaviour[] virtualButtonBehaviours;
    public GameObject firstPanel, secondPanel, thirdPanel, fourthPanel;
    public GameObject cube, sphere;
    public GameObject cafe, potion;
    public GameObject donut, cake;
    public GameObject pumpkin, weapon;
    string vbName;

    void Start()
    {
        //Register with the virtual buttons TrackableBehaviour
        virtualButtonBehaviours = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < virtualButtonBehaviours.Length; ++i)
        {
            virtualButtonBehaviours[i].RegisterOnButtonPressed(OnButtonPressed);
            virtualButtonBehaviours[i].RegisterOnButtonReleased(OnButtonReleased);
        }
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        vbName = vb.VirtualButtonName;

        if (vbName == "VirtualButtonChange")
            VBChangePanels();
        else if (firstPanel.activeInHierarchy)
        {
            ClearCanvas();
            if (vbName == "ButtonV1")
                ShowCube();
            else if (vbName == "ButtonV2")
                ShowSphere();
        }
        else if (secondPanel.activeInHierarchy)
        {
            ClearCanvas();
            if (vbName == "ButtonV1")
                ShowCafe();
            else if (vbName == "ButtonV2")
                ShowPotion();
        }
        else if (thirdPanel.activeInHierarchy)
        {
            ClearCanvas();
            if (vbName == "ButtonV1")
                ShowDonut();
            else if (vbName == "ButtonV2")
                ShowCake();
        }
        else if (fourthPanel.activeInHierarchy)
        {
            ClearCanvas();
            if (vbName == "ButtonV1")
                ShowPumpkin();
            else if (vbName == "ButtonV2")
                ShowWeapon();
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
            Debug.Log("ButtonReleased");
    }

    void VBChangePanels()
    {
        if (firstPanel.activeInHierarchy)
        {
            firstPanel.SetActive(false);
            secondPanel.SetActive(true);
            thirdPanel.SetActive(false);
            fourthPanel.SetActive(false);
        }
        else if (secondPanel.activeInHierarchy)
        {
            firstPanel.SetActive(false);
            secondPanel.SetActive(false);
            thirdPanel.SetActive(true);
            fourthPanel.SetActive(false);
        }
        else if (thirdPanel.activeInHierarchy)
        {
            firstPanel.SetActive(false);
            secondPanel.SetActive(false);
            thirdPanel.SetActive(false);
            fourthPanel.SetActive(true);
        }
        else if (fourthPanel.activeInHierarchy)
        {
            firstPanel.SetActive(true);
            secondPanel.SetActive(false);
            thirdPanel.SetActive(false);
            fourthPanel.SetActive(false);
        }
    }

    void ClearCanvas()
    {
        cube.SetActive(false);
        sphere.SetActive(false);
        cafe.SetActive(false);
        potion.SetActive(false);
        donut.SetActive(false);
        cake.SetActive(false);
        pumpkin.SetActive(false);
        weapon.SetActive(false);
    }

    void ShowCube()
    {
        Debug.Log("Cube");
        cube.SetActive(true);
    }

    void ShowSphere()
    {
        Debug.Log("Sphere");
        sphere.SetActive(true);
    }

    void ShowCafe()
    {
        Debug.Log("Capsule");
        cafe.SetActive(true);
    }

    void ShowPotion()
    {
        Debug.Log("Cylinder");
        potion.SetActive(true);
    }
    
    void ShowDonut()
    {
        Debug.Log("Donut");
        donut.SetActive(true);
    }

    void ShowCake()
    {
        Debug.Log("Cake");
        cake.SetActive(true);
    }    
    
    void ShowPumpkin()
    {
        Debug.Log("Pumpkin");
        pumpkin.SetActive(true);
    }

    void ShowWeapon()
    {
        Debug.Log("Weapon");
        weapon.SetActive(true);
    }

}
