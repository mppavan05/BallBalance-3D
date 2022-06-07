using UnityEngine;
using Cinemachine;

public class CiniCamController : MonoBehaviour
{
   private CiniCamController m_CamController;

    public CinemachineVirtualCamera CinemachineVirtualCamera { get; private set; }

    private void Awake()
    {
        Camera.main.gameObject.TryGetComponent<CinemachineBrain>(out var brain);
        if(brain == null)
        {
            brain = Camera.main.gameObject.AddComponent<CinemachineBrain>();
        }

        CinemachineVirtualCamera = gameObject.AddComponent<CinemachineVirtualCamera>();
        
    }
}
