using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VFXManager : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> VFXs = new List<GameObject>();
    
    [SerializeField]
    private List<ColorProfile> ColorProfiles = new List<ColorProfile>();

    [SerializeField] private List<Light> ParticleLight = new List<Light>();
    
    public Slider slider;
    
    public void ChangeColor()
    {
        foreach (Light light in ParticleLight)
        {
            light.color = ColorProfiles[(int)slider.value].LightColor;
        }
        foreach (var VFX in VFXs)
        {
                foreach (var rend in VFX.GetComponentsInChildren<Renderer>(true))
                {
                    Material mat = rend.material;
                    string shaderName = mat.shader.name;

                    foreach (ColorProfile.ColorEntry entry in ColorProfiles[(int)slider.value].VFXColors)
                    {
                        if (shaderName == entry.ShaderName) 
                        {
                            mat.SetColor(entry.ShaderVariable, entry.color);
                        }
                    }
                }
        }
    }
}
