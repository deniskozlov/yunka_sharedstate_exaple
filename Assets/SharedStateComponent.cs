using UnityEngine;

[RequireComponent(typeof(SharedState), typeof(SharedEvents))]
public abstract class SharedStateComponent : MonoBehaviour
{
    //Ссылка на компонент с общим состоянием
    protected SharedState State { get; private set; }

    //Ссылка на компонент с общими событиями
    protected SharedEvents Events { get; private set; }


    void Start()
    {
        //Получение компонента с общим состоянием
        State = GetComponent<SharedState>();

        //Получение компонента с общими событиями
        Events = GetComponent<SharedEvents>();

        //Для вызова в дочерних классах
        OnStart();
    }

    protected abstract void OnStart();

    void Update()
    {

        //Для вызова в дочерних классах
        OnUpdate();
    }

    protected abstract void OnUpdate();
}
