using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CatDemo : MonoBehaviour
{
    // public TextMeshProUGUI scoreText;
    public int score;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this.gameObject);
    }
}


