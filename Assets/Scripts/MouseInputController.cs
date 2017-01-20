using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MouseInputController : Singleton<MouseInputController> {

    protected MouseInputController() { }

    UnityEvent onLeftMouseClick;
    
    void Start()
    {
        if (onLeftMouseClick == null)
            onLeftMouseClick = new UnityEvent();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            onLeftMouseClick.Invoke();
        }
    }

    public void RegisterOnLeftMouseClickListener(UnityAction action)
    {
        onLeftMouseClick.AddListener(action);
    }

    public Vector2 GetMouseScreenCoords()
    {
        return Camera.main.ScreenToWorldPoint(
            new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10)
            );
    }
}
