using TMPro;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private int score = 0;  // เก็บคะแนน
    public TextMeshProUGUI scoreText;  // UI ที่จะใช้แสดงคะแนน

    // เมื่อชนกับเหรียญ
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))  // ถ้าเป็นเหรียญ
        {
            score++;  // เพิ่มคะแนน
            Destroy(other.gameObject);  // ทำลายเหรียญ
            UpdateScoreText();  // อัพเดทคะแนน
        }
    }

    // อัพเดทข้อความคะแนน
    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;  // แสดงคะแนนใหม่
    }
}