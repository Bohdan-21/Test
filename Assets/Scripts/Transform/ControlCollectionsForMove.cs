using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCollectionsForMove : MonoBehaviour
{
    public void MoveRight()
    {
        foreach(Transform child in transform)
        {
            child.Translate(new Vector3(5, 0, 0));
        }
    }

    public void MoveLeft()
    {
        foreach (Transform child in transform)
        {
            child.Translate(new Vector3(-5, 0, 0));
        }
    }

    public void MoveUp()
    {
        foreach (Transform child in transform)
        {
            child.Translate(new Vector3(0, 0, 5));
        }
    }

    public void MoveDown()
    {
        foreach (Transform child in transform)
        {
            child.Translate(new Vector3(0, 0, -5));
        }
    }
}
