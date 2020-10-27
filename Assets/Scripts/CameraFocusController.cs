using UnityEngine;
using Vuforia;

public class CameraFocusController : MonoBehaviour {

    private bool hasFuforiaStarted = false;

    void Start () 
    {
        VuforiaARController vuforia = VuforiaARController.Instance;

        if (vuforia != null)
            vuforia.RegisterVuforiaStartedCallback(StartAfterVuforia);
    }

    private void StartAfterVuforia()
    {
        hasFuforiaStarted = true;
        SetAutofocus();
    }

    void OnApplicationPause(bool pause)
    {
        if (!pause)
        {
            if (hasFuforiaStarted)
                SetAutofocus();
        }
    }

    void SetAutofocus()
    {
        if (CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO))
            Debug.Log("Autofocus set");
        else
            Debug.Log("No autofocus supported");
    }
}
