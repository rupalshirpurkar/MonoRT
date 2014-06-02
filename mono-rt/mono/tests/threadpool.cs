using System;
using System.Threading;

public class Test {

	static int csum = 0;
	
	public static void test_callback (object state) {
		Console.WriteLine("test_casllback:" + state);
		Thread.Sleep (200);
		Interlocked.Increment (ref csum);
	}
	
	public static int Main () {
		int workerThreads;
		int completionPortThreads;
		
		ThreadPool.GetMaxThreads (out workerThreads, out completionPortThreads);
		Console.WriteLine ("workerThreads: {0} completionPortThreads: {1}", workerThreads, completionPortThreads);

		ThreadPool.GetAvailableThreads (out workerThreads, out completionPortThreads);
		Console.WriteLine ("workerThreads: {0} completionPortThreads: {1}", workerThreads, completionPortThreads);

		ThreadPool.QueueUserWorkItem (new WaitCallback (test_callback), "TEST1");
		//
		//  Beginn Aenderung Test
		//
		Console.WriteLine ("\n\t*** new WaitCallback (test_callback) TEST1 fertig ***\n");
		//
		//  Ende Aenderung Test
		//
		ThreadPool.QueueUserWorkItem (new WaitCallback (test_callback), "TEST2");
		//
		//  Beginn Aenderung Test
		//
		Console.WriteLine ("\n\t*** new WaitCallback (test_callback) TEST2 fertig ***\n");
		//
		//  Ende Aenderung Test
		//
		ThreadPool.QueueUserWorkItem (new WaitCallback (test_callback), "TEST3");
		//
		//  Beginn Aenderung Test
		//
		Console.WriteLine ("\n\t*** new WaitCallback (test_callback) TEST3 fertig ***\n");
		//
		//  Ende Aenderung Test
		//
		ThreadPool.QueueUserWorkItem (new WaitCallback (test_callback), "TEST4");
		//
		//  Beginn Aenderung Test
		//
		Console.WriteLine ("\n\t*** new WaitCallback (test_callback) TEST4 fertig ***\n");
		//
		//  Ende Aenderung Test
		//
		ThreadPool.QueueUserWorkItem (new WaitCallback (test_callback), "TEST5");
		//
		//  Beginn Aenderung Test
		//
		Console.WriteLine ("\n\t*** new WaitCallback (test_callback) TEST5 fertig ***\n");
		//
		//  Ende Aenderung Test
		//
		ThreadPool.QueueUserWorkItem (new WaitCallback (test_callback));
		//
		//  Beginn Aenderung Test
		//
		Console.WriteLine ("\n\t*** new WaitCallback (test_callback) fertig ***\n");
		//
		//  Ende Aenderung Test
		//
		while (csum < 6) {
			Thread.Sleep (100);
		}

		Console.WriteLine ("CSUM: " + csum);

		if (csum != 6)
			return 1;

		return 0;
	}
}
