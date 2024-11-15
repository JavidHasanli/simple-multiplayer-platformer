using TMPro;
using UnityEngine;

namespace Javid.UI.Views
{
    public class MainMenuView : MonoBehaviour
    {
        #region Links&Properties

        [Header("Links")]
        [SerializeField] private TMP_InputField _nickNameField;
        [SerializeField] private TMP_InputField _roomNameField;


        [Header("Properties")]
        public string NickName
        {
            get
            {
                return string.IsNullOrEmpty(_nickNameField.text) ? _nickNamePlaceHolderText.text : _nickNameField.text;
            }
        }

        public string RoomName
        {
            get
            {
                return string.IsNullOrEmpty(_roomNameField.text) ? _roomNamePlaceHolderText.text : _roomNameField.text;
            }
        }

        private TMP_Text _nickNamePlaceHolderText;
        private TMP_Text _roomNamePlaceHolderText;

        #endregion

        #region

        void Awake()
        {
            _nickNamePlaceHolderText = _nickNameField.placeholder.GetComponent<TMP_Text>();
            _roomNamePlaceHolderText = _roomNameField.placeholder.GetComponent<TMP_Text>();
        }

        #endregion

        #region Custom Methods

        public void SetRandomNickName(string nickName)
        {
            _nickNamePlaceHolderText.text = nickName;
        }

        #endregion
    }
}

