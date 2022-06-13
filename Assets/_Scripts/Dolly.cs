using Cinemachine;
using UnityEngine;

namespace _Scripts
{
    public class Dolly : MonoBehaviour
    {
        // Start is called before the first frame update
        private CinemachineVirtualCamera _virtualCamera;
        private CinemachineTrackedDolly _dolly;

        private void Awake()
        {
            _virtualCamera = GetComponent<CinemachineVirtualCamera>();
            _dolly = _virtualCamera.GetCinemachineComponent<CinemachineTrackedDolly>();
        }
    
        private void Update() => _dolly.m_PathPosition += Time.deltaTime;
        
    }
}
