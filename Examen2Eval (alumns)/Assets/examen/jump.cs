using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    //public sandwich(string name) : base(ItemType.SANWICH, name, Resources.Load<Sprite>("Sprite/sanwich"))
    //{

    //}
    public override void Use(GameObject owner)
    {
        Rigidbody2D rb =  owner GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2 (rb.velocity.x, 0f);
        rb.AddForce(Vector2.up * 100f * rb.gravityScale);
    }
}
