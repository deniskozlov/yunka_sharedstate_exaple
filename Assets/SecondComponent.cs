public class SecondComponent : SharedStateComponent
{

    protected override void OnStart()
    {
        //Выполняем метод через 5 секнд
        Invoke("FireWriteSomeDataEvent", 5);
    }

    protected override void OnUpdate()
    {

    }

    //Метод который выполняет публикацию события
    void FireWriteSomeDataEvent()
    {
        Events.Publish("writesomedata", new WriteSomeDataEventData { Sender = this, SomeData = "Привет из SecondComponent" });
    }
}
