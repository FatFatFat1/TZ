using UnityEngine;
/// <summary>
/// Движение и смерть майора 
/// </summary>
public class MajorMove : MonoBehaviour
{
    #region Private Fields

    /// <summary>
    /// игрок
    /// </summary>
    private GameObject _player;

    #endregion Private Fields

    #region Private Methods

    private void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        if (GetComponent<Transform>().position.x < -15)
        {
            Destroy(gameObject); //За военкоматом нет жизни
        }
        if (_player.GetComponent<Fail>().IsLose != true)
        {
            transform.position -= transform.right * Time.deltaTime * 2;
        }
    }

    #endregion Private Methods
}