using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    [Header("Settings")]
    [Tooltip("The speed of the scrolling")]
    public float ScrollSpeed;

    [Header("References")]
    public MeshRenderer MeshRenderer;

    void Start()
    {

    }

    void Update()
    {
        MeshRenderer.material.mainTextureOffset += new Vector2(ScrollSpeed * Time.deltaTime, 0);
    }
}
