using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VBInteraction : MonoBehaviour
{

    VirtualButtonBehaviour[] virtualButtonBehaviours;
    public GameObject firstPanel, secondPanel, thirdPanel;
    public GameObject cube, sphere, capsule, cylinder;
    public GameObject donut, cake;
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
                ShowCapsule();
            else if (vbName == "ButtonV2")
                ShowCylinder();
        }
        else if (thirdPanel.activeInHierarchy)
        {
            ClearCanvas();
            if (vbName == "ButtonV1")
                ShowDonut();
            else if (vbName == "ButtonV2")
                ShowCake();
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
        }
        else if (secondPanel.activeInHierarchy)
        {
            firstPanel.SetActive(false);
            secondPanel.SetActive(false);
            thirdPanel.SetActive(true);
        }
        else if (thirdPanel.activeInHierarchy)
        {
            firstPanel.SetActive(true);
            secondPanel.SetActive(false);
            thirdPanel.SetActive(false);
        }
    }

    void ClearCanvas()
    {
        cube.SetActive(false);
        sphere.SetActive(false);
        capsule.SetActive(false);
        cylinder.SetActive(false);
        donut.SetActive(false);
        cake.SetActive(false);
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

    void ShowCapsule()
    {
        Debug.Log("Capsule");
        capsule.SetActive(true);
    }

    void ShowCylinder()
    {
        Debug.Log("Cylinder");
        cylinder.SetActive(true);
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

}
