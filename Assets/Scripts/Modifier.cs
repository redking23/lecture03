using UnityEngine;

public abstract class Modifier : MonoBehaviour
{
    protected virtual void Log()
    {
        Debug.Log(gameObject.name);
    }

    public abstract void Modify();
}