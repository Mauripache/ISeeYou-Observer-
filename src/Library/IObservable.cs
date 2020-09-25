public interface IObservable
{
    void Notify();
    void Subscribe(IObserver suscriber);
    void Unsubscribe(IObserver suscriber);
}