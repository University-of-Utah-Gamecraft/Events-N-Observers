using UnityEngine;

public class DecoupledCubeBehaviour : MonoBehaviour
{
    private void OnEnable()
    {
        Actions.OnCubeClicked += Clicked;
    }

    private void OnDisable()
    {
        Actions.OnCubeClicked -= Clicked;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Time.deltaTime * 3, 0, 0);
    }

    public void Clicked(GameObject what)
    {
        if (what == this.gameObject) 
        {
            Actions.AddScore?.Invoke(1);
            Destroy(this.gameObject);
        }
    }
}
