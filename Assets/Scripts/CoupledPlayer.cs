using TMPro;
using UnityEngine;

public class CoupledPlayer : MonoBehaviour
{
    private TextMeshProUGUI scoreText;
    private float score = 0f;
    
    void Start()
    {
        scoreText = GameObject.FindGameObjectWithTag("Score").GetComponent<TextMeshProUGUI>();  // Red flag!! The player should not need a direct reference to UI elements
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            DetectObjectClicked();
        }
    }

    void DetectObjectClicked()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);

        if (hit.collider != null)
        {
            if (hit.collider.CompareTag("Cube"))
            {
                score++; // The player should not keep track of score
                scoreText.SetText("Score: " + score); //The player should not set the text of UI elements
                GameObject cubeClicked = hit.collider.gameObject;
                Destroy(cubeClicked); //The player should not destroy the game object

                //This code is HIGHLY coupled and not good!!
            }
        }
    }
}
