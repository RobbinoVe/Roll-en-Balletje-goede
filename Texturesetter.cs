using UnityEngine;

public class TextureSetter : MonoBehaviour
{
    public Texture2D texture;

    void Start()
    {
        if (texture != null)
        {
            SetTexture();
        }
        else
        {
            Debug.LogWarning("Texture not assigned to TextureSetter script!");
        }
    }

    void SetTexture()
    {
        Renderer renderer = GetComponent<Renderer>();
        if (renderer != null)
        {
            Material material = renderer.material;
            if (material != null)
            {
                material.mainTexture = texture;
            }
            else
            {
                Debug.LogWarning("Material not found on GameObject!");
            }
        }
        else
        {
            Debug.LogWarning("Renderer component not found on GameObject!");
        }
    }
}
