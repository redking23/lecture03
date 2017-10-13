using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField]
    private List<Modifier> _modifiers;

    /// <summary>
    /// Called by the UI.
    /// </summary>
    public void OnModifyButtonClicked()
    {
        //First approach
        foreach (Modifier modifier in _modifiers)
        {
            modifier.Modify();
        }

        // Second approach
        // MessageSystem.TriggerModifyButtonClicked();
    }
}