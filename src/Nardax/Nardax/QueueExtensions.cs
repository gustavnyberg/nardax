using System.Collections.Generic;

namespace Nardax
{
  public static class QueueExtensions
  {
    // Lägg in en hel lista med items i en befintlig kö
    
    public static void EnqueueRange<T>(this Queue<T> queue, IEnumerable<T> items)
    {
      foreach (var item in items)
      {
        queue.Enqueue(item);
      }
    }
  }
}