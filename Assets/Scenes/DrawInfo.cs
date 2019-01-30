/*using System.Linq;
using RPGSystem;
using UnityEngine;
using UnityEngine.UI;

public class DrawInfo : MonoBehaviour
{
    public Actor actor;
    public string attributeName;
    public Text text;

    public void Update()
    {
        text.text = "";
        foreach (RPGAttribute attribute in actor.Attributes)
        {
            if (attribute.GetType() == typeof(Vital))
                text.text += string.Format("{0}: {1}/{2}\n", attribute.Name, ((Vital)attribute).CurrentValue, ((Vital)attribute).CurrentMaxValue);
            else
                text.text += string.Format("{0}: {1}\n", attribute.Name, attribute.CurrentValue);
            foreach (Modifier modifier in attribute.Modifiers)
            {
                text.text += string.Format("{0}, {1}, {2}\n", modifier.Source, modifier.Amount, modifier.Duration);
            }
        }
    }

    public void Hit()
    {
        //actor.Attributes.First(x => x.Name.Equals(attributeName)).CurrentValue -= 50;
    }

    public void Heal()
    {
        //actor.Attributes.First(x => x.Name.Equals(attributeName)).CurrentValue += 50;
    }

    public void BuffHealth()
    {
        ModifierFixed modifier = new ModifierFixed();
        modifier.Amount = 150;
        actor.Attributes.First(x => x.Name.Equals(attributeName)).AddModifier(modifier);
    }

    public void DebuffHealth()
    {
        ModifierFixed modifier = new ModifierFixed();
        modifier.Amount = -150;
        actor.Attributes.First(x => x.Name.Equals(attributeName)).AddModifier(modifier);
    }

    public void ClearModifier()
    {
        actor.Attributes.First(x => x.Name.Equals(attributeName)).ClearModifiers();
    }
}*/
