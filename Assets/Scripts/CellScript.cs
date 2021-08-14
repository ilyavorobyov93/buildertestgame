using UnityEngine;
using UnityEngine.EventSystems;
public class CellScript : MonoBehaviour, IPointerClickHandler
{
    public GameObject BuildselectionPanel;
    public bool busyÑell;
    private GameObject UIelem;
    void Awake()
    {
        UIelem =  GameObject.Find("Main Camera");
        busyÑell = true;
        BuildselectionPanel = GameObject.Find("BuildSelectionPanel");
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if (busyÑell == true)
        {
            BuildselectionPanel.SetActive(true);
            BuildselectionPanel.GetComponent<BuildSelectionPanelScript>().buildPos = transform.position;
            BuildselectionPanel.GetComponent<BuildSelectionPanelScript>().Parent = gameObject;
            UIelem.GetComponent<UIScript>().Cell = gameObject;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        busyÑell = false;
    }
    private void OnTriggerExit(Collider other)
    {
        busyÑell = true;
    }
}
