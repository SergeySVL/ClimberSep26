using UnityEngine;

public class bgscroll : MonoBehaviour
{
    public float scroll_Speed = 0.3f;

    private MeshRenderer mesh_Renderer;

    void Awake()
    {
        mesh_Renderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        Scroll();
    }

    void Scroll()
    {
        Vector2 offset = mesh_Renderer.sharedMaterial.GetTextureOffset("_MainTex");
        offset.y += scroll_Speed * Time.deltaTime;
        mesh_Renderer.sharedMaterial.SetTextureOffset("_MainTex", offset);
    }

}
