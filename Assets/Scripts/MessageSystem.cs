using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MessageSystem
{
    public static event Action OnModifyButtonClicked;

    public static void TriggerModifyButtonClicked()
    {
        if (OnModifyButtonClicked != null)
        {
            OnModifyButtonClicked();
        }
    }
}