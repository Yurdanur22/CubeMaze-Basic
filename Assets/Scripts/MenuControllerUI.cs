using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuControllerUI : MonoBehaviour
{
    [SerializeField] private Button _easyButton;
    [SerializeField] private Button _middleButton;
    [SerializeField] private Button _hardButton;

    private void Awake()
    {
        _easyButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("GameScene");

        });
        _middleButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("MiddleScene");
        });
        _hardButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("HardScene");
        });

           
    }


}
