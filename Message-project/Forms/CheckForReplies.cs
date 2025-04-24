using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Message_project.Forms
{
    internal class CheckForReplies
    {
        // Define an event that subscribers can listen to.
        // The event handler sends a message with the elapsed time as a string.
        public event EventHandler<bool> CheckForRepliesEvent;

        // Cancellation token source to stop the loop.
        private CancellationTokenSource _cts;

        // Constructor
        public CheckForReplies()
        {
            _cts = new CancellationTokenSource();
        }

        // Start the asynchronous loop.
        // This method runs until the cancellation token is requested.
        public async Task StartAsync()
        {
            DateTime lastEventTime = DateTime.Now;
            Random random = new Random();

            try
            {
                while (!_cts.Token.IsCancellationRequested)
                {
                    // setting a a random delay between 30 and 60 seconds (in milliseconds)
                    int delay = random.Next(30 * 1000, 60 * 1000);
                    await Task.Delay(delay, _cts.Token);

                    // Вызываем событие, уведомляя подписчиков.
                    OnCheckForReplies(true);
                }
            }
            catch (TaskCanceledException)
            {
                // Обработка отмены (если нужно).
            }
        }

        // Method to cancel the ongoing asynchronous operation.
        public void Stop()
        {
            _cts.Cancel();
        }

        // Protected virtual method to raise the event.
        protected virtual void OnCheckForReplies(bool checkForReplies)
        {
            CheckForRepliesEvent?.Invoke(this, checkForReplies);
        }
    }
}
