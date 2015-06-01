using System;

namespace SigletonPattern.Sigleton
{
	/// <summary>
	/// ���ܣ��򵥵ĵ���ģʽ��
	/// ��д��Terrylee
	/// ���ڣ�2005��12��06��
	/// </summary>
	public class CommonSigleton
	{	
		/// <summary>
		/// ˽�еĶ���
		/// </summary>
		private static CommonSigleton instance;
		
		/// <summary>
		/// ���췽��ΪPrivate
		/// </summary>
		private CommonSigleton()
		{
			
		}
		
		/// <summary>
		/// ���е�����
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
