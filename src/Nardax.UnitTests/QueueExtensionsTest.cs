namespace Nardax.UnitTests
{
  using System.Collections.Generic;
  using Microsoft.VisualStudio.TestTools.UnitTesting;

  [TestClass]
  public class QueueExtensionsTest
  {
    private Queue<string> _queue;

    public QueueExtensionsTest()
    {
      _queue = new Queue<string>();
      _queue.Enqueue("aa");
      _queue.Enqueue("bb");
      _queue.Enqueue("cc");
    }

    [TestMethod]
    public void EnqueueTest()
    {
      _queue.EnqueueRange(new [] {"dd", "ee"});

      Assert.AreEqual("aa", _queue.Dequeue());
      Assert.AreEqual("bb", _queue.Dequeue());
      Assert.AreEqual("cc", _queue.Dequeue());
      Assert.AreEqual("dd", _queue.Dequeue());
      Assert.AreEqual("ee", _queue.Dequeue());
    }
  }
}
