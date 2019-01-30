using System;

/// <summary>
/// Sets the category for creating a new datablock
/// </summary>
[AttributeUsage(AttributeTargets.Class)]
public class DatablockCategoryAttribute : Attribute
{
    public string m_Category;

    public DatablockCategoryAttribute(string category)
    {
        m_Category = category;
    }
}