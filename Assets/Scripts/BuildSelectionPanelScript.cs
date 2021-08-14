using UnityEngine;
using UnityEngine.UI;
public class BuildSelectionPanelScript : MonoBehaviour
{
    public GameObject Parent;
    public Vector3 buildPos;
    public Button BuildOk;
    private int selectedbuilding;
    public GameObject[] Buildings = new GameObject[8];

    public void Build1Instantiate()
    {
        selectedbuilding = 0;
        BuildOk.interactable = true;
    }
    public void Build2Instantiate()
    {
        selectedbuilding = 1;
        BuildOk.interactable = true;
    }
    public void Build3Instantiate()
    {
        selectedbuilding = 2;
        BuildOk.interactable = true;
    }
    public void Build4Instantiate()
    {
        selectedbuilding = 3;
        BuildOk.interactable = true;
    }
    public void Build5Instantiate()
    {
        selectedbuilding = 4;
        BuildOk.interactable = true;
    }
    public void Build6Instantiate()
    {
        selectedbuilding = 5;
        BuildOk.interactable = true;
    }
    public void Build7Instantiate()
    {
        selectedbuilding = 6;
        BuildOk.interactable = true;
    }
    public void Build8Instantiate()
    {
        selectedbuilding = 7;
        BuildOk.interactable = true;
    }
    public void BuildOKButton()
    {
        GameObject build = Instantiate(Buildings[selectedbuilding], buildPos, Parent.transform.rotation);
        build.transform.SetParent(Parent.transform);
        BuildOk.interactable = false;
        gameObject.SetActive(false);
        Parent.GetComponent<CellScript>().busy—ell = false;
        if(selectedbuilding ==6)
        {
            build.tag = "color1";
            build.transform.position = Parent.transform.position;
        }
        if (selectedbuilding == 7)
        {
            build.tag = "color2";
        }
		MyObjectOnScene myObjectOnScene = build.GetComponent<MyObjectOnScene>();
    }
}
