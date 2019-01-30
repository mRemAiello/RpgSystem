using System;
using UnityEngine;

namespace RPGSystem
{
    [Serializable]
    public class CustomValueInteger : CustomValue<int>
    {
        public CustomValueInteger(string id, string name, int data) : base(id, name, data)
        {
        }
    }

    [Serializable]
    public class CustomValueFloat : CustomValue<float>
    {
        public CustomValueFloat(string id, string name, float data) : base(id, name, data)
        {
        }
    }

    [Serializable]
    public class CustomValueBoolean : CustomValue<bool>
    {
        public CustomValueBoolean(string id, string name, bool data) : base(id, name, data)
        {
        }
    }

    [Serializable]
    public class CustomValueString : CustomValue<string>
    {
        public CustomValueString(string id, string name, string data) : base(id, name, data)
        {
        }
    }

    [Serializable]
    public class CustomValueColor : CustomValue<Color>
    {
        public CustomValueColor(string id, string name, Color data) : base(id, name, data)
        {
        }
    }

    [Serializable]
    public class CustomValueSprite : CustomValue<Sprite>
    {
        public CustomValueSprite(string id, string name, Sprite data) : base(id, name, data)
        {
        }
    }

    [Serializable]
    public class CustomValueVector2 : CustomValue<Vector2>
    {
        public CustomValueVector2(string id, string name, Vector2 data) : base(id, name, data)
        {
        }
    }

    [Serializable]
    public class CustomValueVector3 : CustomValue<Vector3>
    {
        public CustomValueVector3(string id, string name, Vector3 data) : base(id, name, data)
        {
        }
    }
}
