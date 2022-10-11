using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LogInteractions : MonoBehaviour
{
    public void LogHoverEnter(HoverEnterEventArgs args)
    {
        Debug.Log(gameObject.name + " Hover Enter by: " + args.interactorObject);

    }

    public void LogHoverExit(HoverExitEventArgs args)
    {
        Debug.Log(gameObject.name + " Hover Exit by: " + args.interactorObject);

    }

    public void LogSelectEnter(SelectEnterEventArgs args)
    {
        Debug.Log(gameObject.name + " Select Enter by: " + args.interactorObject);

    }

    public void LogSelectExit(SelectExitEventArgs args)
    {
        Debug.Log(gameObject.name + " Select Exit by: " + args.interactorObject);

    }

    public void LogActivate(ActivateEventArgs args)
    {
        Debug.Log(gameObject.name + " Activate by: " + args.interactorObject);

    }

    public void LogDeactivate(DeactivateEventArgs args)
    {
        Debug.Log(gameObject.name + " Deactivate by: " + args.interactorObject);

    }
}
