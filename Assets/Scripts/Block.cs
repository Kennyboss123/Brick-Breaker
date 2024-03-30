using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Block : MonoBehaviour
{
    [SerializeField] Sprite[] level2Blocks;
    int hitCount = 0;
    LevelLoader level;

    private void Start()
    {
        level = FindObjectOfType<LevelLoader>();
        level.CountBreakableBlocks();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ball" && gameObject.tag == "Level 1 Block")
        {
            level.DestroyedBlocks();
            Destroy(gameObject);
            GameManager.Instance.AddScore(20);
        }
/*
        if (collision.gameObject.tag == "Ball" && gameObject.tag == "Level 2 Block")
        {
            hitCount++;
            if (hitCount == 1)
            {
                GetComponent<SpriteRenderer>().sprite = level2Blocks[1];
            }
            if (hitCount >= 2)
            {
                Destroy(gameObject);
            }
        }*/
    }
}
