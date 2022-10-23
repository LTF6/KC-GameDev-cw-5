using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class counter : MonoBehaviour
{

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI winText;
    public int score = 0;
    public int x;

    // Cats sorry its looong
    public GameObject Cat;
    public GameObject Cat1;
    public GameObject Cat2;
    public GameObject Cat3;
    public GameObject Cat4;
    public GameObject Cat5;
    public GameObject Cat6;
    public GameObject Cat7;
    public GameObject Cat8;
    public GameObject Cat9;
    public GameObject Cat10;
    public GameObject Cat11;
    public GameObject Cat12;
    public GameObject Cat13;
    public GameObject Cat14;
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject == Cat) {
            score = score + 1;
            scoreText.text = "Score : " + score;
        }else if (collision.gameObject == Cat1) {
            score = score + 1;
            scoreText.text = "Score : " + score;
        }else if (collision.gameObject == Cat2) {
            score = score + 1;
            scoreText.text = "Score : " + score;
        }else if (collision.gameObject == Cat3) {
            score = score + 1;
            scoreText.text = "Score : " + score;
        }else if (collision.gameObject == Cat4) {
            score = score + 1;
            scoreText.text = "Score : " + score;
        }else if (collision.gameObject == Cat5) {
            score = score + 1;
            scoreText.text = "Score : " + score;
        }else if (collision.gameObject == Cat6) {
            score = score + 1;
            scoreText.text = "Score : " + score;
        }else if (collision.gameObject == Cat7) {
            score = score + 1;
            scoreText.text = "Score : " + score;
        }else if (collision.gameObject == Cat8) {
            score = score + 1;
            scoreText.text = "Score : " + score;
        }else if (collision.gameObject == Cat9) {
            score = score + 1;
            scoreText.text = "Score : " + score;
        }else if (collision.gameObject == Cat10) {
            score = score + 1;
            scoreText.text = "Score : " + score;
        }else if (collision.gameObject == Cat11) {
            score = score + 1;
            scoreText.text = "Score : " + score;
        }else if (collision.gameObject == Cat12) {
            score = score + 1;
            scoreText.text = "Score : " + score;
        }else if (collision.gameObject == Cat13) {
            score = score + 1;
            scoreText.text = "Score : " + score;
        }else if (collision.gameObject == Cat14) {
            score = score + 1;
            scoreText.text = "Score : " + score;
        } else if( score == 15){
            winText.text = "Nerd Cat is now Feelling satiety\r\n                and happy !";
        }
        else {
            Debug.Log("Please Hit a cat");
        }
        



    }
}
