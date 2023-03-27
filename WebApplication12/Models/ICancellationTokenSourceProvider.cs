namespace WebApplication12.Models
{
    public interface ICancellationTokenSourceProvider
    {
        CancellationTokenSource GetCancellationTokenSource();
        void SetCancellationTokenSource();
    }

    public class CancellationTokenSourceProvider : ICancellationTokenSourceProvider
    {
        private readonly CancellationTokenSource _cancellationTokenSource;

        public CancellationTokenSourceProvider()
        {
            _cancellationTokenSource = new CancellationTokenSource();
        }

        public CancellationTokenSource GetCancellationTokenSource()
        {
            return _cancellationTokenSource;
        }

        public void SetCancellationTokenSource()
        {
            _cancellationTokenSource.Cancel();
        }
    }
}
