using UnityEngine;

public class LoopingBackground : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float backgroundSpeed;
    public Renderer backgroundRenderer;

    // Update is called once per frame
    void Update()
    {
        backgroundRenderer.material.mainTextureOffset += new Vector2(backgroundSpeed * Time.deltaTime, 0f);
    }
}
