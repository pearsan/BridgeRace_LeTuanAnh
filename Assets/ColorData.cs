using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class ColorData : Singleton<ColorData>
{
    [FormerlySerializedAs("ColorDataSo")] public ColorDataSO ColorDataSO;
    
    private void Awake()
    {
        DontDestroyOnLoad(gameObject); // Prevent this instance from being destroyed when loading a new scene
    }
}
