using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class NameInput : MonoBehaviour
{
    [SerializeField] private Game _game;

    private TextMeshProUGUI _name;

    private void Start()
    {
        _name = GetComponent<TextMeshProUGUI>();
    }

    private void OnEnable()
    {
        _game.StartAnotherScene += OnStartAnotherScene;
    }

    private void OnDisable()
    {
        _game.StartAnotherScene -= OnStartAnotherScene;
    }

    private void OnStartAnotherScene()
    {
        PlayerInfo.ChangeName(_name.text);
    }
}
