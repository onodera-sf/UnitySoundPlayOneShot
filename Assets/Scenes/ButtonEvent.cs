using System.Threading.Tasks;
using UnityEngine;

public class ButtonEvent : MonoBehaviour
{
  [SerializeField] private AudioSource AudioSource;

  /// <summary>音声データ。</summary>
  [SerializeField] private AudioClip AudioClip;

  public void OnClickPlay()
  {
    // オーディオを再生します
    AudioSource.PlayOneShot(AudioClip);
  }
}
