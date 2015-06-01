using System;
using System.Threading;

namespace SigletonPattern.SigletonCounter
{
	/// <summary>
	/// 功能：简单计数器的单件模式
	/// 编写：Terrylee
	/// 日期：2005年12月06日
	/// </summary>
	public class CountSigleton
	{
		///存储唯一的实例
		static CountSigleton uniCounter = new CountSigleton();  
   
		///存储计数值
		private int totNum = 0;  

   
		private CountSigleton() 
   
		{ 
			///线程延迟2000毫秒
			Thread.Sleep(2000);
		} 
   
		static public CountSigleton Instance() 
   
		{ 
   
			return uniCounter; 
   
		} 
		
		///计数加1
		public void Add()
		{ 
			totNum ++;
		}  
		
		///获得当前计数值
		public int GetCounter()
		{ 
			return totNum;
		} 

	}
}
