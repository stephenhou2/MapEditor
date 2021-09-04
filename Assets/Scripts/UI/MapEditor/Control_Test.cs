﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control_Test : UIControl
{
    private GameObject Button_Test;

    private void OnTestButtonClick()
    {
        Log.Logic("OnTestButtonClick");

        //UIManager.Ins.RemoveControl(mHolder,this);

        UIManager.Ins.AddControl<Control_Test2>(this, "UI/MapEditor/Control_Test2", mRoot);
    }
    
    protected override void BindUINodes()
    {
        BindButtonNode(ref Button_Test, "Button_Test", OnTestButtonClick);
    }

    protected override void OnClose()
    {
        Log.Logic("Control_Test OnClose");
    }

    protected override void OnOpen()
    {
        Log.Logic("Control_Test OnOpen");
    }
}
