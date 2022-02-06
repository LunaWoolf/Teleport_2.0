using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    public Material[] materials;
    public Shader targetShader;
    
    void Start()
    {
        for (int i = 0; i < materials.Length; i++)
        {
            Material m = materials[i];
            Color mColor = new Color(Random.Range(0, 255), Random.Range(0,255), Random.Range(0,255), 254f);
            m.SetColor("_BaseColor", mColor);
        }
        
    }

 
}
