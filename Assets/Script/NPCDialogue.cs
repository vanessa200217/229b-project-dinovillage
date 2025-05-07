using System.Collections;
using UnityEngine;
using TMPro;

public class NPCDialogue : MonoBehaviour
{
    public string dialogue = "Hello Dino!";
    public TextMeshProUGUI dialogueText;
    public float displayTime = 3f;

    private bool playerInRange = false;

    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            StartCoroutine(DisplayDialogue());
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
        }
    }

    private IEnumerator DisplayDialogue()
    {
        dialogueText.text = dialogue;
        yield return new WaitForSeconds(displayTime);
        dialogueText.text = "";
    }
}