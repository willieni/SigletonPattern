using System;

namespace SigletonPattern.Sigleton
{
	/// <summary>
	/// ���ܣ�����DotNet������ʵ�ֵ���ģʽ
	/// ��д��WillieNi
	/// ���ڣ�2015��06��01��
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
