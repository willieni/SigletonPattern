using System;
using System.Text;
using System.Threading;

namespace SigletonPattern.SigletonCounter
{
	/// <summary>
	/// ���ܣ�ʵ�ֶ��̼߳������Ŀͻ���
	/// ��д��Terrylee
	/// ���ڣ�2005��12��06��
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
