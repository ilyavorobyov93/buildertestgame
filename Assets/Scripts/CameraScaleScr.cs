using UnityEngine;
public class CameraScaleScr : MonoBehaviour
{
    [Header("вращение - кнопки A и D")]
    [SerializeField] GameObject Ground;
    private float rotatespeed;
    private float _zoomCam;
    void Start()
    {
        rotatespeed = 0.1f;
        _zoomCam = 80.0f;
    }
    void Update()
    {
        Camera.main.fieldOfView = _zoomCam;
        
        if(Input.GetAxis ("Mouse ScrollWheel") < 0)
        {
            _zoomCam++;
        }
        else if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            _zoomCam--;
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            _zoomCam++;
        }
        else if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            _zoomCam--;
        }
        if (Input.GetKey(KeyCode.A))
        {
            Ground.transform.Rotate(0f, rotatespeed, 0f);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            Ground.transform.Rotate(0f, (rotatespeed * -1), 0f);
        }
    }
}
