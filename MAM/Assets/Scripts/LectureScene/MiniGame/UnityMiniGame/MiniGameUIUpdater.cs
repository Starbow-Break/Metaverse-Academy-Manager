using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MiniGameUIUpdater : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _time;
    [SerializeField] private TextMeshProUGUI _score;
    [SerializeField] private GameObject _timePanel;

    [SerializeField] private TextMeshProUGUI _gradeText;
    [SerializeField] private Button _clickBlockButton;

    [SerializeField] private Button _skipButton;

    public Button SkipButton => _skipButton;
    public Button ClickBlockButton => _clickBlockButton;

    private void Start()
    {
        gameObject.SetActive(false);
        _timePanel.SetActive(false);
        _clickBlockButton.gameObject.SetActive(false);
        _gradeText.gameObject.SetActive(false);
    }

    public void SetScore(float score)
    {
        _score.text = score.ToString();
    }

    public void SetTime(float time)
    {
        _time.text = Mathf.CeilToInt(time).ToString();
    }

    public void ShowTime()
    {
        _timePanel.SetActive(true);
    }

    public void SetAndShowGrade(string grade, Color color)
    {
        _gradeText.text = grade;
        _gradeText.color = color;
        _gradeText.gameObject.SetActive(true);
        _clickBlockButton.gameObject.SetActive(true);
    }
}