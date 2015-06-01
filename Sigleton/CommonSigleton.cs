using System;

namespace SigletonPattern.Sigleton
{
	/// <summary>
	/// 功能：简单的单件模式类
	/// 编写：Terrylee
	/// 日期：2005年12月06日
	/// </summary>
	public class CommonSigleton
	{	
		/// <summary>
		/// 私有的对象
		/// </summary>
		private static CommonSigleton instance;
		
		/// <summary>
		/// 构造方法为Private
		/// </summary>
		private CommonSigleton()
		{
			
		}
		
		/// <summary>
		/// 公有的属性
		/// </summary>
		public static CommonSigleton Instance
		{
			get
			{
				if(instance == null)
				{
					instance = new CommonSigleton();
				}

				return instance;
			}
		}
	}
}
