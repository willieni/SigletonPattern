using System;

namespace SigletonPattern.Sigleton
{
	/// <summary>
	/// ���ܣ�����DotNet������ʵ�ֵ���ģʽ
	/// ��д��Terrylee
	/// ���ڣ�2005��12��06��
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
