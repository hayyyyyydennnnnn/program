using UnityEngine;
using UnityEngine.UI;

public class DifficultyButton : MonoBehaviour
{
    private Button button;
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficulty);
    }


    void Update()
    {

    }
    
    void SetDifficulty()
    {
        Debug.Log(gameObject.name + " was clicked");
    }
}
