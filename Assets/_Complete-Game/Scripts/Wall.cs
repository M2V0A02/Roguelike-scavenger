using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite damageSprite;
    public int hp = 4;

    private SpriteRenderer spriteRenderer;

    void Awake()
    {
        spriteRender = GetComponent<SpriteRenderer>();
    }

    public void DamageWall (int loss)
    {
        spriteRender.sprite = damageSprite;
        hp -= loss;
        if (hp == 0)
            gamageObject.setActive(false);
    }
}
