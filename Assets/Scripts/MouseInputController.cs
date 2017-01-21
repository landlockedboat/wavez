using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MouseInputController : Singleton<MouseInputController> {

    protected MouseInputController() { }

    UnityEvent onLeftMouseClick;
    UnityEvent onLeftMouseRelease;
    [SerializeField]
    float cameraHeight;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            onLeftMouseClick.Invoke();
        }
        else if (Input.GetMouseButtonUp(0))
        {
            onLeftMouseRelease.Invoke();
        }
    }

    public void RegisterOnLeftMouseReleaseListener(UnityAction action)
    {
        if (onLeftMouseRelease == null)
            onLeftMouseRelease = new UnityEvent();
        onLeftMouseRelease.AddListener(action);
    }

    public void RegisterOnLeftMouseClickListener(UnityAction action)
    {
        if (onLeftMouseClick == null)
            onLeftMouseClick = new UnityEvent();
        onLeftMouseClick.AddListener(action);
    }

    public Vector2 GetMouseScreenCoords()
    {
        return Camera.main.ScreenToWorldPoint(
            new Vector3(Input.mousePosition.x, Input.mousePosition.y, -cameraHeight)
            );
    }
}
