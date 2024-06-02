using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class UImanager : MonoBehaviour
{
   public static UImanager Instance;
    private Dictionary<string, GameObject> _elements;
    private UImanager()
    {
        _elements = new Dictionary<string, GameObject>();
    }
   public static UImanager GetInstance()
    {
        if (Instance == null)
        {
            Instance = new UImanager();
        }
        return Instance;
    }
    public void AddIElement(string key, GameObject value)
    {
        _elements.Add(key, value);
    }
    public GameObject GetUIElemet(string key)
    {

        return _elements[key];
    }
}
