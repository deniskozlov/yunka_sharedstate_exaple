using System.Collections.Generic;
using UnityEngine;

public class SharedState : MonoBehaviour
{
    //Закрытый словарь, который будет содержать все данные
    private Dictionary<string, object> _data = new Dictionary<string, object>();

    //Индексатор для доступа к данным
    public object this[string key]
    {
        get { return _data[key]; }
        set { _data[key] = value; }
    }
}
