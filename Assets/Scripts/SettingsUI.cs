using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SettingsUI : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private GameObject _settingsPopupObject;
    [SerializeField] private GameObject _blackBackgroundObject;
    [Header("Buttons")]
    [SerializeField] private Button _settingsButton;
    [SerializeField] private Button _resumeButton;
    [SerializeField] private Button _mainMenuButton;

    private Image _blackBackgroundImage;
    private void Awake()
    {
        _blackBackgroundImage = _blackBackgroundObject.GetComponent<Image>();
       
        _settingsButton.onClick.AddListener(OnSettingsButtonClicked);
        _resumeButton.onClick.AddListener(OnResumeButtonClicked);
        _mainMenuButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("MenuScene");
        });

    }
    private void OnSettingsButtonClicked()
    {
        _blackBackgroundObject.SetActive(true);
        _settingsPopupObject.SetActive(true);
        
    }
    private void OnResumeButtonClicked()
    {
        _blackBackgroundObject.SetActive(false);
        _settingsPopupObject.SetActive(false);

    }



}
