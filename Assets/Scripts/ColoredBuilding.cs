using UnityEngine;
using UnityEngine.EventSystems;
public class ColoredBuilding : MonoBehaviour, IPointerClickHandler
{
    public Material[] mat1 = new Material[4];
    public Material[] mat2 = new Material[4];
    private GameObject —olor—hangePanel;
    private MeshRenderer _meshRenederer;
    private int lvl;
    void Awake()
    {
        _meshRenederer = GetComponent<MeshRenderer>();
        lvl = 1;
        —olor—hangePanel = Camera.main.GetComponent<UIScript>().—olor—hangePanel;
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        Camera.main.GetComponent<UIScript>().Build = gameObject;
        —olor—hangePanel.SetActive(true);
    }
    public void ColorChangeBuild()
    {
        if (gameObject.tag == "color1")
        {
            if (lvl == 1)
            {
                lvl++;
                _meshRenederer.material = mat1[0];
            }
            else if (lvl == 2)
            {
                lvl++;
                _meshRenederer.material = mat1[1];
            }
            else if (lvl == 3)
            {
                lvl++;
                _meshRenederer.material = mat1[2];
            }
            else if (lvl == 4)
            {
                lvl++;
                _meshRenederer.material = mat1[3];
            }
        }
        else if (gameObject.tag == "color2")
        {
            if (lvl == 1)
            {
                lvl++;
                _meshRenederer.material = mat2[0];
            }
            else if (lvl == 2)
            {
                lvl++;
                _meshRenederer.material = mat2[1];
            }
            else if (lvl == 3)
            {
                lvl++;
                _meshRenederer.material = mat2[2];
            }
            else if (lvl == 4)
            {
                lvl++;
                _meshRenederer.material = mat2[3];
            }
        }
    }
}
