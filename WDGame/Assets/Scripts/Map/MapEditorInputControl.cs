﻿using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MapEditorInputControl:IInputControl
{
    private bool mTouchDownOnUI;
    private int mTouchCount = 0;
    private Vector2 mTouchPos = Vector2.one;
    private bool mDrag = false;

    private Dictionary<string, IInputHandle> mInputHandleDic;

    public MapEditorInputControl()
    {
        mInputHandleDic = new Dictionary<string, IInputHandle>();
    }

    public void RegisterInputHandle(IInputHandle inputHandle)
    {
        if (mInputHandleDic == null)
            return;

        if (inputHandle == null)
            return;

        string handleName = inputHandle.GetHandleName();

        if(!mInputHandleDic.ContainsKey(handleName))
        {
            mInputHandleDic.Add(handleName, inputHandle);
        }
    }

    public void UpdateTouchDown(Vector2 touchPos)
    {
        if (mTouchDownOnUI)
            return;

        mTouchPos = touchPos;
        mDrag = false;
        mTouchCount = 1;

        foreach (KeyValuePair<string,IInputHandle> kv in mInputHandleDic)
        {
            kv.Value.OnTouchDown(mTouchPos);
        }

        mDrag = false;
    }

    public void UpdateTouchUp()
    {
        if (mTouchDownOnUI)
            return;

        mDrag = false;
        mTouchCount = 0;

        if (!mDrag)
        {
            foreach (KeyValuePair<string, IInputHandle> kv in mInputHandleDic)
            {
                kv.Value.OnTouchUp(mTouchPos);
            }
        }

        mTouchPos = Vector2.zero;
    }

    public void UpdateTouchDrag(Vector2 touchPos)
    {
        if (mTouchDownOnUI)
            return;

        Vector3 deltaPos = touchPos - mTouchPos;
        if (Mathf.Abs(deltaPos.x) < 0.1f && Mathf.Abs(deltaPos.y) < 0.1f)
            return;

        mTouchPos = touchPos;
        mDrag = true;
        foreach (KeyValuePair<string, IInputHandle> kv in mInputHandleDic)
        {
            kv.Value.OnDrag(deltaPos, mTouchPos);
        }
    }

    public void UpdateTouchZoom(float zoomChange)
    {
        foreach (KeyValuePair<string, IInputHandle> kv in mInputHandleDic)
        {
            kv.Value.OnZoom(zoomChange);
        }
    }

    public void InputControlUpdate(float deltaTime)
    {
#if UNITY_EDITOR
        if (Input.GetMouseButtonDown(0))
        {
            mTouchDownOnUI = EventSystem.current.IsPointerOverGameObject();
            UpdateTouchDown(Input.mousePosition);
        }
        else if (Input.GetMouseButtonUp(0))
        {
            UpdateTouchUp();
        }
        else if (mTouchCount == 1)
        {
            UpdateTouchDrag(Input.mousePosition);
        }

        float zoomChange = Input.GetAxis("Mouse ScrollWheel");
        if (zoomChange != 0)
        {
            UpdateTouchZoom(zoomChange);
        }
#else
        Vector3 pos = Vector3.zero;
         if (mTouchCount == 0 && Input.touchCount == 1)
        {
            mTouchDownOnUI = EventSystem.current.IsPointerOverGameObject();
            UpdateTouchDown(Input.GetTouch(0).position);
        }
        else if(mTouchCount > 0 && Input.touchCount == 0)
        {
            UpdateTouchUp();
        }
        else if(mTouchCount == 1 && Input.touchCount == 1)
        {
            UpdateTouchDrag(Input.GetTouch(0).position);
        }
        else if(mTouchCount == 2 && Input.touchCount == 2)
        {
            float zoomChange = 0;
            if (zoomChange != 0)
            {
                UpdateTouchZoom(zoomChange);
            }
        }
#endif
    }

    void Reset()
    {
        mTouchDownOnUI = false;
        mTouchCount = 0;
        mTouchPos = Vector2.one;
        mDrag = false;
    }

    public void OnEnter()
    {
        Reset();
        foreach(var kv in mInputHandleDic)
        {
            kv.Value.InitializeInputControl();
        }
    }

    public void OnExit()
    {
        
    }
}
