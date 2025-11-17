using System;
using UnityEngine;
using UnityEngine.Events;

public class ClickableObject : MonoBehaviour
{
    public UnityEvent OnObjectClick;
    public UnityEvent OnObjectHover;
    public UnityEvent OnObjectEndHover;
    private void OnMouseDown()
    {
        if (OnObjectClick != null)
        {
            OnObjectClick.Invoke();
        }
    }

    private void OnMouseEnter()
    {
        if (OnObjectHover != null)
        {
            OnObjectHover.Invoke();
        }
    }
    
    private void OnMouseExit()
    {
        if (OnObjectEndHover != null)
        {
            OnObjectEndHover.Invoke();
        }
    }
}
