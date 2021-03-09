namespace DefaultNamespace
{
    public interface IObservable
    {
        void registerObserver(IObserver o);
        void unregisterObserver(IObserver o);
        void notifyObservers();
    }
}