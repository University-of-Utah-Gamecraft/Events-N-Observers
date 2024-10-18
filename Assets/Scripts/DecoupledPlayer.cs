using UnityEngine;

public class DecoupledPlayer : MonoBehaviour
{
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
                Actions.OnCubeClicked?.Invoke(hit.collider.gameObject);
            }
        }
    }
}
