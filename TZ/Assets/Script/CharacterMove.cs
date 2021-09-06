using UnityEngine;

/// <summary>
/// Движение персонажа для ПК и ИОС с АНДРОИДОМ
/// </summary>
public class CharacterMove : MonoBehaviour
{
    #region Public Fields

    /// <summary>
    /// Риг игрока
    /// </summary>
    public Rigidbody2D Player;

    #endregion Public Fields

    #region Private Fields

    /// <summary>
    /// Аниматор игрока
    /// </summary>
    private Animator _anim;

    #endregion Private Fields

    #region Private Methods

    private void Start()
    {
        _anim = GetComponent<Animator>();
    }

    private void Update()
    {
#if UNITY_STANDALONE
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Player.AddForce(transform.up * 10.0f, ForceMode2D.Impulse);
            _anim.SetBool("IsJump", true);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            _anim.SetBool("IsJump", false);
        }
#elif UNITY_IOS || UNITY_ANDROID
         if(Input.touchCount > 0)
         {
            Touch myTouch =  Input.GetTouch(0);
            if(myTouch.phase == TouchPhase.Began)
             {
                Player.AddForce(transform.up * 10.0f, ForceMode2D.Impulse);
                _anim.SetBool("IsJump", true);
             }
             if(myTouch.phase == TouchPhase.Ended)
             {
                _anim.SetBool("IsJump", false);
             }
         }
#endif
    }

    #endregion Private Methods
}