using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EndLevelScreen : MonoBehaviour
{
    [SerializeField] Image CloseButton;
    [SerializeField] Image Ribbon;
    [SerializeField] TMP_Text RibbonText;
    [SerializeField] RectTransform Stars;
    [SerializeField] Image StarLeft;
    [SerializeField] Image StarMid;
    [SerializeField] Image StarRight;
    [SerializeField] RectTransform TimeLeft;
    [SerializeField] TMP_Text TimeLeft_Text;
    [SerializeField] Image ContinueButton;
    // TODO: make more elaborate
    [SerializeField] RectTransform Booster_Choice;

    [SerializeField] Sprite RibbonPositive;
    [SerializeField] Sprite RibbonNegative;
    [SerializeField] string RibbonTextPositive = "Level complete";
    [SerializeField] string RibbonTextNegative = "Level failed";

    public void InitWinScreen(string timeString)
    {
        Deconstruct(); // just in case
        gameObject.SetActive(true);
        InitCommonParts();

        Ribbon.sprite = RibbonPositive;
        RibbonText.text = RibbonTextPositive;
        Stars.gameObject.SetActive(true);
        TimeLeft.gameObject.SetActive(true);
        TimeLeft_Text.text = timeString;
    }

    public void InitLoseScreen()
    {
        Deconstruct(); // just in case
        gameObject.SetActive(true);
        InitCommonParts();

        Ribbon.sprite = RibbonNegative;
        RibbonText.text = RibbonTextNegative;
        Booster_Choice.gameObject.SetActive(true);
    }

    private void InitCommonParts()
    {
        CloseButton.gameObject.SetActive(true);
        Ribbon.gameObject.SetActive(true);
        ContinueButton.gameObject.SetActive(true);
    }

    public void Deconstruct()
    {
        CloseButton.gameObject.SetActive(false);
        Ribbon.gameObject.SetActive(false);
        RibbonText.text = "";
        Stars.gameObject.SetActive(false);
        TimeLeft.gameObject.SetActive(false);
        TimeLeft_Text.text = "";
        ContinueButton.gameObject.SetActive(false);
        Booster_Choice.gameObject.SetActive(false);
        gameObject.SetActive(false);
    }

}
