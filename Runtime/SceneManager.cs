using UnityEngine;
using UnityEngine.SceneManagement;

namespace Bin.SceneManager
{
    /// <summary>
    /// 場景管理器：切換場景與關閉遊戲
    /// </summary>
    public class SceneManager : MonoBehaviour
    {
        [SerializeField, Range(0.3f, 3)]
        private float SoundDuration = 0.8f;

        private int SceneIndex;

        public void ChangeScene(int SceneIndex)
        {
            this.SceneIndex = SceneIndex;
            Invoke("DelayChangeScene", SoundDuration);
        }

        public void DelayChangeScene()
        {
            print("切換場景");
            UnityEngine.SceneManagement.SceneManager.LoadScene(SceneIndex);
        }


        public void Quit()
        {
            Invoke("DelayQuit", SoundDuration);
        }

        private void DelayQuit()
        {
            print("關閉遊戲");
            Application.Quit();
        }
    }

}
