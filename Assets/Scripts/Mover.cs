using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : Modifier
{
    public float Duration;
    public float PositionLimit;

    void OnEnable()
    {
        // MessageSystem.OnModifyButtonClicked += Modify;
    }

    void OnDisable()
    {
        // MessageSystem.OnModifyButtonClicked += Modify;
    }

    public override void Modify()
    {
        Log();
        StartCoroutine(Move());
    }

    protected override void Log()
    {
        base.Log();
        Debug.Log("Moved.");
    }

    private IEnumerator Move()
    {
        Vector3 oldPosition = transform.localPosition;

        float newX = Random.Range(-PositionLimit, PositionLimit);
        float newY = Random.Range(-PositionLimit, PositionLimit);
        float newZ = Random.Range(-PositionLimit, PositionLimit);
        Vector3 newPosition = new Vector3(newX, newY, newZ);

        float timePassed = 0f;

        while (timePassed < Duration)
        {
            yield return new WaitForEndOfFrame();
            timePassed += Time.deltaTime;
            transform.localPosition = Vector3.Lerp(oldPosition, newPosition, timePassed / Duration);
        }
    }
}