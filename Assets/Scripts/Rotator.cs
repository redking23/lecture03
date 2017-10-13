using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : Modifier
{
    public float Duration;
    public float RotationLimit;

    public override void Modify()
    {
        Log();
        StartCoroutine(Rotate());
    }

    protected override void Log()
    {
        base.Log();
        Debug.Log("Rotated.");
    }

    private IEnumerator Rotate()
    {
        Quaternion oldRotation = transform.localRotation;

        float newX = Random.Range(-RotationLimit, RotationLimit);
        float newY = Random.Range(-RotationLimit, RotationLimit);
        float newZ = Random.Range(-RotationLimit, RotationLimit);
        Quaternion newRotation = Quaternion.Euler(new Vector3(newX, newY, newZ));

        float timePassed = 0f;

        while (timePassed < Duration)
        {
            yield return new WaitForEndOfFrame();
            timePassed += Time.deltaTime;
            transform.localRotation = Quaternion.Lerp(oldRotation, newRotation, timePassed / Duration);
        }
    }
}