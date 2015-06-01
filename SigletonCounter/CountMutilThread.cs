using System;
using System.Threading;
using System.Text;

namespace SigletonPattern.SigletonCounter
{
	/// <summary>
	/// ���ܣ�����һ�����̼߳�������
	/// ��д��Terrylee
	/// ���ڣ�2005��12��06��
	/// </summary>
	public class CountMutilThread
	{
		public CountMutilThread()
		{
			
		}

		/// <summary>
		/// �̹߳���
		/// </summary>
		public static void DoSomeWork()
		{
			///������ʾ�ַ���
			string results = "";

			///����һ��Sigletonʵ��
			CountSigleton MyCounter = CountSigleton.Instance();

			///ѭ�������Ĵ�
			for(int i=1;i<5;i++)
			{
				///��ʼ����
				MyCounter.Add();
                
				results +="�߳�";
				results += i.ToString() + "������";
				results += "��ǰ�ļ�����";
				results += MyCounter.GetCounter().ToString();
				results += "\n";

				Console.WriteLine(results);
				
				///�����ʾ�ַ���
				results = "";
			}
		}

		public void StartMain()
		{

			Thread thread0 = Thread.CurrentThread; 
   
			thread0.Name = "Thread 0"; 
   
			Thread thread1 =new Thread(new ThreadStart(DoSomeWork)); 
   
			thread1.Name = "Thread 1"; 
   
			Thread thread2 =new Thread(new ThreadStart(DoSomeWork)); 
   
			thread2.Name = "Thread 2"; 
   
			Thread thread3 =new Thread(new ThreadStart(DoSomeWork)); 
   
			thread3.Name = "Thread 3"; 
   
			thread1.Start(); 
   
			thread2.Start(); 
   
			thread3.Start(); 
			
			///�߳�0Ҳִֻ�к������߳���ͬ�Ĺ���
			DoSomeWork(); 
		}
	}
}
