using UnityEngine;

public class ChangeMaterialColor : MonoBehaviour
{
    [SerializeField] private Color color;
    
    private static readonly int ColorID = Shader.PropertyToID("_BaseColor");

    private void Awake()
    {
        GetComponent<Renderer>().material.SetColor(ColorID, color);
    }
}
