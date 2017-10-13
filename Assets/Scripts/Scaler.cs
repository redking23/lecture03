using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : Modifier
{
    public float Duration;
    public float ScaleLimit;

    public override void Modify()
    {
        Log();
        StartCoroutine(Scale());
    }

    protected override void Log()
    {
        base.Log();
        Debug.Log("Scaled.");
    }

    private IEnumerator Scale()
    {
        Vector3 oldScale = transform.localScale;

        float newX = Random.Range(-ScaleLimit, ScaleLimit);
        float newY = Random.Range(-ScaleLimit, ScaleLimit);
        float newZ = Random.Range(-ScaleLimit, ScaleLimit);
        Vector3 newScale = new Vector3(newX, newY, newZ);

        float timePassed = 0f;

        while (timePassed < Duration)
        {
            yield return new WaitForEndOfFrame();
            timePassed += Time.deltaTime;
            transform.localScale = Vector3.Lerp(oldScale, newScale, timePassed / Duration);
        }
    }
}