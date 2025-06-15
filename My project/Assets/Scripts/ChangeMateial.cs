using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    public Material[] materials;
    private Renderer renderer;

    public void ChangeMaterials(int materialIndex)
    {
        if (materialIndex >= 0 && materialIndex < materials.Length)
        {
            renderer.material = materials[materialIndex];
            SaveMaterialIndex(materialIndex);
        }
    }

    public void SaveMaterialIndex(int materialIndex)
    {
        PlayerPrefs.SetInt("MaterialIndex", materialIndex);
        PlayerPrefs.Save();
    }

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}