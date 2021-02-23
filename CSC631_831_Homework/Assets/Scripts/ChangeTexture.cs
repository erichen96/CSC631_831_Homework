using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeTexture : MonoBehaviour
{
    [SerializeField]
    private GameObject plane;

    [SerializeField]
    private Texture[] textures;

    private Renderer planeRenderer;
    
    private int randomTextureIndex;
    

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Change Texture");
        planeRenderer = plane.GetComponent<Renderer>();
        gameObject.GetComponent<Button>().onClick.AddListener(ChangeCubeTexture);
    }

    // Update is called once per frame
    private void ChangeCubeTexture()
    {
        randomTextureIndex = Random.Range(0, textures.Length);
        planeRenderer.material.mainTexture = textures[randomTextureIndex];
    }
}
