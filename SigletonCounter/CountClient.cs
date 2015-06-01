using System;
using System.Text;
using System.Threading;

namespace SigletonPattern.SigletonCounter
{
	/// <summary>
	/// 功能：实现多线程计数器的客户端
	/// 编写：Terrylee
	/// 日期：2005年12月06日
	/// </summary>
	public class CountClient
	{
		public static void Main(string[] args)
		{
			CountMutilThread cmt = new CountMutilThread();

			cmt.StartMain();

			Console.ReadLine();
		}
	}
}
