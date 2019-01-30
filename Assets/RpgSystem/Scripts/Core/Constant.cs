using UnityEngine;

namespace RPGSystem
{
    public class Constant
    {
        public static string DB_FOLDER = @"Resources/RpgSystem_Data";

        public static string DB_MAIN_NAME = @"Database.prefab";
        public static string DB_CUSTOM_VALUE_NAME = @"CustomValue.asset";
        public static string DB_ATTRIBUTE_NAME = @"Attribute.asset";
        public static string DB_CLASS_NAME = @"Class.asset";
        public static string DB_ITEM_CATEGORY_NAME = @"ItemCategory.asset";
        public static string DB_RARITY_NAME = @"Rarity.asset";
        public static string DB_EQUIP_TYPE_NAME = @"EquipType.asset";
        public static string DB_ITEM_NAME = @"Item.asset";

        public static Color COLOR_WHITE = Color.white;
        public static Color COLOR_GRAY = new Color(0.6f, 0.6f, 0.6f);
        public static Color COLOR_GREEN = Color.green;
        public static Color COLOR_RED = Color.red;

        public static int MAIN_WINDOW_WIDTH = 1200;
        public static int MAIN_WINDOW_HEIGHT = 630;

        public static int SPACE_VERY_LIGHT = 3;
        public static int SPACE_LIGHT = 7;
        public static int SPACE_MEDIUM = 14;
        public static int SPACE_HIGH = 18;
        public static int SPACE_VERY_HIGH = 25;
        public static int SPACE_HEADER = 35;
    }
}
