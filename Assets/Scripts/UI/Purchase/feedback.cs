using TMPro;
using UnityEngine;

namespace Assets.Scripts.UI.Purchase
{
    public class feedback : MonoBehaviour
    {
        [SerializeField] private TMP_Text _description;
        public void ShowMessage(string text)
        {
            gameObject.SetActive(true);
            _description.text = text;
        }
    }
}