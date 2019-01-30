using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace RPGSystem
{
    public class CustomValueManager
    {
        public static dynamic GetCustomValue<T>(List<CustomValueAll> customValues, string name)
        {
            List<CustomValueAll> list = customValues.Where(x => x.Name == name).ToList();

            int i = 0;
            int index = 0;
            bool founded = false;
            if (typeof(T) == typeof(int))
            {
                CustomValueInteger intVar = null;
                foreach (CustomValueAll element in list)
                {
                    if (!founded && element.type == CustomValueEnumType.Integer)
                    {
                        intVar = element.customValueInteger;
                        founded = true;
                        index = i;
                    }
                    i++;
                }
                if (intVar != null)
                    return new CustomValue<int>(list[index].ID.ToString(), name, intVar.Data);
            }
            else if (typeof(T) == typeof(float))
            {
                CustomValueFloat floatVar = null;
                foreach (CustomValueAll element in list)
                {
                    if (!founded && element.type == CustomValueEnumType.Float)
                    {
                        floatVar = element.customValueFloat;
                        founded = true;
                        index = i;
                    }
                    i++;
                }
                if (floatVar != null)
                    return new CustomValue<float>(list[index].ID.ToString(), name, floatVar.Data);
            }
            else if (typeof(T) == typeof(bool))
            {
                CustomValueBoolean boolVar = null;
                foreach (CustomValueAll element in list)
                {
                    if (!founded && element.type == CustomValueEnumType.Boolean)
                    {
                        boolVar = element.customValueBoolean;
                        founded = true;
                        index = i;
                    }
                    i++;
                }               
                if (boolVar != null)
                    return new CustomValue<bool>(list[index].ID.ToString(), name, boolVar.Data);
            }
            else if (typeof(T) == typeof(string))
            {
                CustomValueString strVar = null;
                foreach (CustomValueAll element in list)
                {
                    if (!founded && element.type == CustomValueEnumType.String)
                    {
                        strVar = element.customValueString;
                        founded = true;
                        index = i;
                    }
                    i++;
                }
                if (strVar != null)
                    return new CustomValue<string>(list[index].ID.ToString(), name, strVar.Data);
            }
            else if (typeof(T) == typeof(Vector2))
            {
                CustomValueVector2 vectorVar = null;
                foreach (CustomValueAll element in list)
                {
                    if (!founded && element.type == CustomValueEnumType.Vector2)
                    {
                        vectorVar = element.customValueVector2;
                        founded = true;
                        index = i;
                    }
                    i++;
                }
                if (vectorVar != null)
                    return new CustomValue<Vector2>(list[index].ID.ToString(), name, vectorVar.Data);
            }
            else if (typeof(T) == typeof(Vector3))
            {
                CustomValueVector3 vectorVar = null;
                foreach (CustomValueAll element in list)
                {
                    if (!founded && element.type == CustomValueEnumType.Vector3)
                    {
                        vectorVar = element.customValueVector3;
                        founded = true;
                        index = i;
                    }
                    i++;
                }
                if (vectorVar != null)
                    return new CustomValue<Vector3>(list[index].ID.ToString(), name, vectorVar.Data);
            }
            else if (typeof(T) == typeof(Color))
            {
                CustomValueColor colorVar = null;
                foreach (CustomValueAll element in list)
                {
                    if (!founded && element.type == CustomValueEnumType.Color)
                    {
                        colorVar = element.customValueColor;
                        founded = true;
                        index = i;
                    }
                    i++;
                }
                if (colorVar != null)
                    return new CustomValue<Color>(list[index].ID.ToString(), name, colorVar.Data);
            }
            else if (typeof(T) == typeof(Sprite))
            {
                CustomValueSprite spriteVar = null;
                foreach (CustomValueAll element in list)
                {
                    if (!founded && element.type == CustomValueEnumType.Sprite)
                    {
                        spriteVar = element.customValueSprite;
                        founded = true;
                        index = i;
                    }
                    i++;
                }
                if (spriteVar != null)
                    return new CustomValue<Sprite>(list[index].ID.ToString(), name, spriteVar.Data);
            }

            return null;
        }

        public static dynamic GetCustomValue<T>(List<CustomValueAll> customValues, Guid id)
        {
            List<CustomValueAll> list = customValues.Where(x => x.ID == id).ToList();

            int i = 0;
            int index = 0;
            bool founded = false;
            if (typeof(T) == typeof(int))
            {
                CustomValueInteger intVar = null;
                foreach (CustomValueAll element in list)
                {
                    if (!founded && element.type == CustomValueEnumType.Integer)
                    {
                        intVar = element.customValueInteger;
                        founded = true;
                        index = i;
                    }
                    i++;
                }
                if (intVar != null)
                    return new CustomValue<int>(list[index].ID.ToString(), list[index].Name, intVar.Data);
            }
            else if (typeof(T) == typeof(float))
            {
                CustomValueFloat floatVar = null;
                foreach (CustomValueAll element in list)
                {
                    if (!founded && element.type == CustomValueEnumType.Float)
                    {
                        floatVar = element.customValueFloat;
                        founded = true;
                        index = i;
                    }
                    i++;
                }
                if (floatVar != null)
                    return new CustomValue<float>(list[index].ID.ToString(), list[index].Name, floatVar.Data);
            }
            else if (typeof(T) == typeof(bool))
            {
                CustomValueBoolean boolVar = null;
                foreach (CustomValueAll element in list)
                {
                    if (!founded && element.type == CustomValueEnumType.Boolean)
                    {
                        boolVar = element.customValueBoolean;
                        founded = true;
                        index = i;
                    }
                    i++;
                }
                if (boolVar != null)
                    return new CustomValue<bool>(list[index].ID.ToString(), list[index].Name, boolVar.Data);
            }
            else if (typeof(T) == typeof(string))
            {
                CustomValueString strVar = null;
                foreach (CustomValueAll element in list)
                {
                    if (!founded && element.type == CustomValueEnumType.String)
                    {
                        strVar = element.customValueString;
                        founded = true;
                        index = i;
                    }
                    i++;
                }
                if (strVar != null)
                    return new CustomValue<string>(list[index].ID.ToString(), list[index].Name, strVar.Data);
            }
            else if (typeof(T) == typeof(Vector2))
            {
                CustomValueVector2 vectorVar = null;
                foreach (CustomValueAll element in list)
                {
                    if (!founded && element.type == CustomValueEnumType.Vector2)
                    {
                        vectorVar = element.customValueVector2;
                        founded = true;
                        index = i;
                    }
                    i++;
                }
                if (vectorVar != null)
                    return new CustomValue<Vector2>(list[index].ID.ToString(), list[index].Name, vectorVar.Data);
            }
            else if (typeof(T) == typeof(Vector3))
            {
                CustomValueVector3 vectorVar = null;
                foreach (CustomValueAll element in list)
                {
                    if (!founded && element.type == CustomValueEnumType.Vector3)
                    {
                        vectorVar = element.customValueVector3;
                        founded = true;
                        index = i;
                    }
                    i++;
                }
                if (vectorVar != null)
                    return new CustomValue<Vector3>(list[index].ID.ToString(), list[index].Name, vectorVar.Data);
            }
            else if (typeof(T) == typeof(Color))
            {
                CustomValueColor colorVar = null;
                foreach (CustomValueAll element in list)
                {
                    if (!founded && element.type == CustomValueEnumType.Color)
                    {
                        colorVar = element.customValueColor;
                        founded = true;
                        index = i;
                    }
                    i++;
                }
                if (colorVar != null)
                    return new CustomValue<Color>(list[index].ID.ToString(), list[index].Name, colorVar.Data);
            }
            else if (typeof(T) == typeof(Sprite))
            {
                CustomValueSprite spriteVar = null;
                foreach (CustomValueAll element in list)
                {
                    if (!founded && element.type == CustomValueEnumType.Sprite)
                    {
                        spriteVar = element.customValueSprite;
                        founded = true;
                        index = i;
                    }
                    i++;
                }
                if (spriteVar != null)
                    return new CustomValue<Sprite>(list[index].ID.ToString(), list[index].Name, spriteVar.Data);
            }

            return null;
        }
    }
}
