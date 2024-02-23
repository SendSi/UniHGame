using UnityEngine;


public class ImgMoveUp : MonoBehaviour
{
    Material material;
    public Vector2 speed;
    Vector2 movement = Vector2.one;
    private void Start()
    {
        material = this.GetComponent<Renderer>().material;
    }

    private void Update()
    {
        movement += Time.deltaTime * speed;
        material.mainTextureOffset = movement;
    }
}

