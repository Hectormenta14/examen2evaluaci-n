using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvas : MonoBehaviour
{
    void Awake()
    {
        foreach (Tranform child in transform)
        {
            UImanager.GetInstance().AddIElement(child.name, child.gameObject);
        }
    }
}
