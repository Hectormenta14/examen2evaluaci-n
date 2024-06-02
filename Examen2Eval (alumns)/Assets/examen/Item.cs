using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using TMPro;
using UnityEngine;

public class Item : MonoBehaviour
{
    public Item(ItemType type,string name, Sprite sprite)
    {
        private string _name;
        private ItemType _type
        private Sprite _sprite;
        public abstract void Use(GameObject owner);
        public ItemType GetItemType()
        {
            return _type;
        }
        public Sprite GetSprite()
        {
            return _sprite;
        }
        public string GetName()
        {
            return _name;
        }


    }
}
