using System.Threading.Tasks;
using UnityEngine;

public class ButtonEvent : MonoBehaviour
{
  [SerializeField] private AudioSource AudioSource;

  /// <summary>�����f�[�^�B</summary>
  [SerializeField] private AudioClip AudioClip;

  public void OnClickPlay()
  {
    // �I�[�f�B�I���Đ����܂�
    AudioSource.PlayOneShot(AudioClip);
  }
}
