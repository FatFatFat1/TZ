using UnityEngine;
/// <summary>
/// Генератор Майоров
/// </summary>
public class MajorGenerator : MonoBehaviour
{
    #region Public Fields
    /// <summary>
    /// Товарищ Майор
    /// </summary>
    public GameObject Major;
    /// <summary>
    /// Призывник
    /// </summary>
    public GameObject Player;
    /// <summary>
    /// Летящий невидимый gameObject тригер которого дает очки
    /// </summary>
    public GameObject ScopeZone;

    #endregion Public Fields

    #region Private Fields

    /// <summary>
    /// Ширина отверстия майоров
    /// </summary>
    private Vector2 difference = new Vector2(0, 4);

    /// <summary>
    /// Где генерация майоров
    /// </summary>
    private Vector2 point;

    /// <summary>
    /// Раз в сколько секунд нужно рожать майоров.
    /// </summary>
    private float time = 3;

    #endregion Private Fields

    #region Private Methods

    private void Generation(Vector2 point)
    {
        Instantiate(Major, point - difference, Quaternion.identity);
        Instantiate(Major, point + difference, Quaternion.identity);
        Instantiate(ScopeZone, point, Quaternion.identity);
    }

    private void Update()
    {
        if (Player.GetComponent<Fail>().IsLose != true)
        {
            time -= Time.deltaTime;
            if (time <= 0)
            {
                point = new Vector2(20, Random.Range(0, 3));
                Generation(point);
                time = 3;
            }
        }
    }

    #endregion Private Methods
}