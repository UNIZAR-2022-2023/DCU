using UnityEngine;
using System.Collections;
using System.IO;

public class CombineSprites : MonoBehaviour {

    public SpriteRenderer sprite1;
    public SpriteRenderer sprite2;

    private RenderTexture rt;

    void Start () {
        rt = new RenderTexture(sprite1.sprite.texture.width, sprite1.sprite.texture.height, 0);
        gameObject.GetComponent<Renderer>().material.mainTexture = rt;
    }

    void OnRenderImage(RenderTexture source, RenderTexture destination) {
        RenderTexture.active = rt;
        GL.Clear(true, true, Color.clear);
        Graphics.Blit(sprite1.sprite.texture, rt);
        Graphics.Blit(sprite2.sprite.texture, rt);
        RenderTexture.active = null;

        Texture2D texture = new Texture2D(rt.width, rt.height, TextureFormat.RGB24, false);
        texture.ReadPixels(new Rect(0, 0, rt.width, rt.height), 0, 0);
        texture.Apply();

        byte[] bytes = texture.EncodeToPNG();
        File.WriteAllBytes(Application.dataPath + "/CombinedImage.png", bytes);

        Graphics.Blit(source, destination);
    }
}

