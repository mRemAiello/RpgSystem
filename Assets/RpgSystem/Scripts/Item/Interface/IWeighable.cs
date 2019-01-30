using UnityEngine;
using System.Collections;

public interface IWeighable
{
    bool IsWeighable
    {
        get;
        set;
    }

    uint Weight
    {
        get;
        set;
    }
}
