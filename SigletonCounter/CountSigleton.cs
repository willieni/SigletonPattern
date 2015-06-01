using System;
using System.Threading;

namespace SigletonPattern.SigletonCounter
{
	/// <summary>
	/// ���ܣ��򵥼������ĵ���ģʽ
	/// ��д��Terrylee
	/// ���ڣ�2005��12��06��
	/// </summary>
	public class CountSigleton
	{
		///�洢Ψһ��ʵ��
		static CountSigleton uniCounter = new CountSigleton();  
   
		///�洢����ֵ
		private int totNum = 0;  

   
		private CountSigleton() 
   
		{ 
			///�߳��ӳ�2000����
			Thread.Sleep(2000);
		} 
   
		static public CountSigleton Instance() 
   
		{ 
   
			return uniCounter; 
   
		} 
		
		///������1
		public void Add()
		{ 
			totNum ++;
		}  
		
		///��õ�ǰ����ֵ
		public int GetCounter()
		{ 
			return totNum;
		} 

	}
}
