using RPGSystem;
using System.Collections.Generic;
using UnityEngine;

public class MyCharacter : MonoBehaviour
{
    private void Start()
    {
        Actor actor = GetComponent<Actor>();

        Debug.Log(actor.Class.GetCustomValue<int>("values"));
        Debug.Log(actor.Class.GetCustomValue<float>("values"));
        Debug.Log(actor.Class.GetCustomValue<string>("name"));
        Debug.Log(actor.Class.GetCustomValue<Vector3>("coord"));
        Debug.Log(actor.Class.GetCustomValue<bool>("isSkin"));
        Debug.Log(actor.Class.GetCustomValue<Sprite>("icons"));
        Debug.Log(actor.Class.GetCustomValue<Color>("rarity"));
        Debug.Log(actor.Class.GetCustomValue<Vector2>("coord2"));
    }
}
