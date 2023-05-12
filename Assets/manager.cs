using System;
using System.Collections;
using UnityEngine;

public class manager : MonoBehaviour
{

    [SerializeField] private Transform[] CubeList;
    [SerializeField] private float speedRotate;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) StartCoroutine("LifeRoutine");
    }

    private IEnumerator LifeRoutine()
    {
        for (var i = 0; i < CubeList.Length; i++)
        {
            yield return StartCoroutine(RotateRoutine(CubeList[i], 1));
        }
    }

    IEnumerator RotateRoutine(Transform o, float duration)
    {
        float timer = 0;
        while (timer < 1)
        {
            timer = Math.Min(timer + Time.deltaTime / duration, 1);
            o.Rotate(Vector3.up, speedRotate);
            yield return null;
        }
    }
}
