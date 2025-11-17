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
        Debug.Log(gameObject.name + " foi clicado!");

        if (OnObjectClick != null)
        {
            OnObjectClick.Invoke();
        }
    }

    private void OnMouseEnter()
    {
        Debug.Log(gameObject.name + " foi hovered!");

        if (OnObjectHover != null)
        {
            OnObjectHover.Invoke();
        }
    }
    
    private void OnMouseExit()
    {
        Debug.Log(gameObject.name + " foi hovered!");

        if (OnObjectEndHover != null)
        {
            OnObjectEndHover.Invoke();
        }
    }
}
