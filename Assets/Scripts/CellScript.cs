using UnityEngine;
using UnityEngine.EventSystems;
public class CellScript : MonoBehaviour, IPointerClickHandler
{
    public GameObject BuildselectionPanel;
    public bool busy�ell;
    private GameObject UIelem;
    void Awake()
    {
        UIelem =  GameObject.Find("Main Camera");
        busy�ell = true;
        BuildselectionPanel = GameObject.Find("BuildSelectionPanel");
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if (busy�ell == true)
        {
            BuildselectionPanel.SetActive(true);
            BuildselectionPanel.GetComponent<BuildSelectionPanelScript>().buildPos = transform.position;
            BuildselectionPanel.GetComponent<BuildSelectionPanelScript>().Parent = gameObject;
            UIelem.GetComponent<UIScript>().Cell = gameObject;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        busy�ell = false;
    }
    private void OnTriggerExit(Collider other)
    {
        busy�ell = true;
    }
}
