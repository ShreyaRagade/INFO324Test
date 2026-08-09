using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

namespace DoubleTechniStyle
{
    public class GetName : MonoBehaviour
    {
        public GameObject enterPanel;
        public GameObject mainPanel;
        private TMP_InputField nameInputField;

        private void Start()
        {
            nameInputField = GetComponent<TMP_InputField>();
            EventSystem.current.SetSelectedGameObject(nameInputField.gameObject);
        }
        public void SavePlayerName()
        {
            GlobalHelper.playerName = nameInputField.text.ToCharArray();
            Debug.Log(GlobalHelper.playerName);
            mainPanel.SetActive(true);

        }

        
    }
}
