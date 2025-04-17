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
            // Record the start time.
            DateTime lastEventTime = DateTime.Now;

            // Create a Random instance to generate time intervals.
            Random random = new Random();

            try
            {
                // Continue until cancellation is requested.
                while (!_cts.Token.IsCancellationRequested)
                {
                    // Generate a random delay between 1 and 5 minutes (in milliseconds).
                    int delay = random.Next(1 * 30 * 1000, 1 * 60 * 1000);
                    await Task.Delay(delay, _cts.Token);

                    // not sure if i need this
                    // Calculate elapsed time since the last event was fired.
                    DateTime currentTime = DateTime.Now;
                    TimeSpan elapsedTime = currentTime - lastEventTime;
                    lastEventTime = currentTime;
                }
            }
            catch (TaskCanceledException)
            {
                // Handle the cancellation gracefully if needed.
            }
        }

        // Method to cancel the ongoing asynchronous operation.
        public void Stop()
        {
            _cts.Cancel();
        }

        // Protected virtual method to raise the event.
        protected virtual void OnTimeElapsed(bool checkForReplies)
        {
            CheckForRepliesEvent?.Invoke(this, checkForReplies);
        }
    }
}
