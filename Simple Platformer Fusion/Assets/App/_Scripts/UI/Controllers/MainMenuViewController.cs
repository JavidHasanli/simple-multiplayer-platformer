using DynamicBox.EventManagement;
using Fusion;
using Javid.Events;
using Javid.UI.Views;
using UnityEngine;

namespace Javid.UI.Controllers
{
    public class MainMenuViewController : MonoBehaviour
    {

        #region Properties&Links

        [Header("View")]
        [SerializeField] private MainMenuView _view;

        [Header("Properties")]
        public string NickName => _view.NickName;
        public string RoomName => _view.RoomName;

        #endregion

        #region Unity Methods

        private void Start()
        {
            _view.SetRandomNickName(GetRandomNickName());
        }

        #endregion

        #region Custom Methods
       
        public void JoinRoom()
        {
            EventManager.Instance.Raise(new OnGameStartedEvent(NickName, RoomName, GameMode.Client));
        }

        public void HostRoom()
        {
            EventManager.Instance.Raise(new OnGameStartedEvent(NickName, RoomName, GameMode.Host));
        }

        private string GetRandomNickName()
        {
            return $"Player {Random.Range(1000, 10000)}";
        }

        #endregion
    }
}

