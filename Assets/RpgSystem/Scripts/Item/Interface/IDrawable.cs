namespace RPGSystem
{
    public interface IDrawable
    {
#if UNITY_EDITOR
        void InitEditorGUI();
        void DrawEditorGUI();
#endif
    }
}
