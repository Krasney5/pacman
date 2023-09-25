using TMPro;
using UnityEngine;



namespace ScriptsPoint
{


    public class keyControler : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _scoreText;
        [SerializeField] private int _score;
        [SerializeField] private GameObject[] _key;
        [SerializeField] private GameObject[] _door;

        private void Start()
        {
            _scoreText.text = _score.ToString();
            SpawnKey();
        }

        public void addScore()
        {
            _score++;
            _scoreText.text = _score.ToString();
            print("бубл");
        }

        private void SpawnKey()
        {
            _key[Random.Range(0, _key.Length)].SetActive(true);
        }

        public void SpawnDoor()
        {
            _door[Random.Range(0, _door.Length)].SetActive(true);
        }
    }
}