using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ColorProfile", menuName = "Scriptable Objects/ColorProfile")]
public class ColorProfile : ScriptableObject
{
        [System.Serializable]
        public struct ColorEntry
        {
            public string ShaderName;
            public string ShaderVariable;

            [ColorUsage(false, true)] public Color color;
        }
        
        public List<ColorEntry> VFXColors = new List<ColorEntry>();

        [ColorUsage(false, true)]
        public Color LightColor;

}