using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class BuildWithDescription2 : MonoBehaviour, IPointerClickHandler
{
    private GameObject InfoPanel;
    private Text InfoText;
    private string InfoAboutBuild2;
    void Awake()
    {
        InfoAboutBuild2 = "ÿ‡ıÚ‡";
        InfoPanel = Camera.main.GetComponent<UIScript>().InfoPanel;
        InfoText = Camera.main.GetComponent<UIScript>().InfoText;
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        InfoText.text = InfoAboutBuild2;
        InfoPanel.SetActive(true);
    }
}
