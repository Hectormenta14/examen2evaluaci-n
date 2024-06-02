using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speed : MonoBehaviour
{
    //public sandwich(string name) : base(ItemType.SANWICH, name, Resources.Load<Sprite>("Sprite/sanwich"))
    //{

    //}
    public override void Use(GameObject owner)
    {
        PlayerMovement pm = owner.GetComponent<PlayerMovement>();
        pm.speed *= 1.5f;
    }
}
