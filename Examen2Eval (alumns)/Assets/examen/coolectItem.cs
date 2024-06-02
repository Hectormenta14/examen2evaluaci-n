using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using static UnityEditor.Progress;

public class coolectItem : MonoBehaviour
{
    public ItemType itemType;
    private Item _item;
    private void Start()
    {
        switch (ItemType)
        {
            case ItemType.JUMP
                _item = new jump("pocion salto");
                break;
            case ItemType.SPEED
                _item = new speed("pocion velocidad");
                break;
            case ItemType.SANDWICH
                _item = new sandwich("pocion color");
                break;
                

        }
        GetComponent<SpriteRenderer>().sprite = _item.GetSprite();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerMovement>())
        {
            _item.Use(collision.gameObject);
            Destroy(gameObject);
        }
    }



}
