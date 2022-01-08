using NaughtyAttributes;
using UnityEngine;

public class Step : MonoBehaviour
{
    [TextArea(6, 10)]
    public string Content;
    public string Location;
    public Step[] Steps;
    [ShowAssetPreview()]
    public Sprite Picture;
}