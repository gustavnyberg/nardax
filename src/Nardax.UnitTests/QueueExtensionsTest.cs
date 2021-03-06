﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Nardax.UnitTests
{
  using System.Collections.Generic;

  [TestClass]
  public class QueueExtensionsTest
  {
    

    public QueueExtensionsTest()
    {
      _queue = new Queue<string>();
      _queue.Enqueue("aa");
      _queue.Enqueue("bb");zzzzzzzzzzzzz
      _queue.Enqueue("cc");
    }

    [TestMethod]
    public void EnqueueTest()zzzzzzzzzzzzzzzzzz
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
