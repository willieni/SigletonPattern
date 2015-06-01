using System;

namespace SigletonPattern.Sigleton
{
	/// <summary>
	/// 功能：利用DotNet的特性实现单件模式
	/// 编写：Terrylee
	/// 日期：2005年12月06日
	/// </summary>
	public class DotNetSigleton
	{
		private static readonly DotNetSigleton instance = new DotNetSigleton();
   
		private DotNetSigleton(){}

		public static DotNetSigleton Instance
		{
			get 
			{
				return instance; 
			}
		}

	}
}
