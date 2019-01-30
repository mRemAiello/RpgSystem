/*using UnityEditor;
using UnityEngine;

namespace RPGSystem
{
    [CustomEditor(typeof(ItemData))]
    public class ItemDataEditor : Editor
    {
        ItemData data;

        private void OnEnable()
        {
            data = (ItemData)target;
        }

        public void DrawEditorGUI()
        {
            /** Basic Options **/
            /*GUILayout.BeginHorizontal();
            data.Icon = CustomEditorGUILayout.IconField("Icon", data.Icon);

            GUILayout.BeginVertical();
            data.Name = CustomEditorGUILayout.TextField("Name", data.Name);
            data.ShortName = CustomEditorGUILayout.TextField("Short Name", data.ShortName);
            data.Description = CustomEditorGUILayout.TextArea("Description", data.Description);

            /** Buy Options **/
            /*GUILayout.BeginHorizontal();
            data.IsBuyable = CustomEditorGUILayout.ToggleField("Is Buyable", data.IsBuyable);
            GUILayout.EndHorizontal();
            if (data.IsBuyable)
                data.BuyPrice = CustomEditorGUILayout.IntField("Buy Price", data.BuyPrice);

            /** Sell Options **/
            /*GUILayout.BeginHorizontal();
            data.IsSellable = CustomEditorGUILayout.ToggleField("Is Sellable", data.IsSellable);
            GUILayout.EndHorizontal();
            if (data.IsSellable)
                data.SellPrice = CustomEditorGUILayout.IntField("Sell Price", data.SellPrice);

            /** Durability Options **/
            /*GUILayout.BeginHorizontal();
            data.IsDestructible = EditorGUILayout.Toggle(data.IsDestructible, GUILayout.Width(15));
            EditorGUILayout.LabelField("Have Durability", "", GUILayout.Width(55));
            GUILayout.EndHorizontal();
            if (data.IsDestructible)
            {
                data.MaxDurability = EditorGUILayout.IntField("Max Durability", data.MaxDurability, "textarea");
                GUILayout.Space(Constant.SPACE_LIGHT);
            }
            GUILayout.EndVertical();

            GUILayout.EndHorizontal();
        }
    }
}
*/