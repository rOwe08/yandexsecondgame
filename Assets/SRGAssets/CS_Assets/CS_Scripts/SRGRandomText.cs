using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using YG;
using TMPro;

namespace SpeederRunGame.Types
{
	/// <summary>
	/// This script changes the text based on the platform type we are using.
	/// </summary>
	public class SRGRandomText:MonoBehaviour
	{
		// The text that will be displayed
		public string[] textEnList;

        public string[] textRusList;
        /// <summary>
        /// Start is only called once in the lifetime of the behaviour.
        /// The difference between Awake and Start is that Start is only called if the script instance is enabled.
        /// This allows you to delay any initialization code, until it is really needed.
        /// Awake is always called before any Start functions.
        /// This allows you to order initialization of scripts
        /// </summary>
        void Start()
		{
            TakeRangomWord();
        }

        public void TakeRangomWord()
        {
            if (YandexGame.EnvironmentData.language == "ru")
            {
                if (textRusList.Length > 0) GetComponent<TextMeshProUGUI>().text = textRusList[Mathf.FloorToInt(Random.Range(0, textRusList.Length))];
            }
            else
            {
                if (textEnList.Length > 0) GetComponent<TextMeshProUGUI>().text = textEnList[Mathf.FloorToInt(Random.Range(0, textEnList.Length))];
            }
        }
	}
}