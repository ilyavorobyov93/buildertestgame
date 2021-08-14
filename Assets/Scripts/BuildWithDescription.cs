using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class BuildWithDescription : MonoBehaviour, IPointerClickHandler
{
    private GameObject InfoPanel;
    private Text InfoText;
    private string InfoAboutBuild1;
    void Awake()
    {
        InfoAboutBuild1 = "Магазин игрушек";
        InfoPanel = Camera.main.GetComponent<UIScript>().InfoPanel;
        InfoText = Camera.main.GetComponent<UIScript>().InfoText;
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        InfoText.text = InfoAboutBuild1;
        InfoPanel.SetActive(true);
    }
}
