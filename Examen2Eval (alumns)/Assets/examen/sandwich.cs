using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sandwich : MonoBehaviour
{
    public sandwich(string name) : base(ItemType.SANWICH , name, Resources.Load<Sprite>("Sprite/sanwich"))
    {

    }
    public override void Use(GameObject owner)
    {
        SpriteRenderer spriteRenderer = owner.GetComponent<SpriteRenderer>();
        spriteRenderer.color = Color.green;
        PlayerMovement pm = owner.GetComponent<PlayerMovement>();
        pm.speed /= 2;
    }
}
