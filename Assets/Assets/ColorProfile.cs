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


        //Eu tenho uma key que é composta do NomeDoshader + Propriedade. e o value que é a Color
        //eu tenhoq ue pegar o key, dar um parse até o _, separar em shader e color. verificar o material, se contem o shader e se contem a 
        //no render, eu checo pra ver se tem um render, e vejo se tem material, se se o material contem o shader 



}