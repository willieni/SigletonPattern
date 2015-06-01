using System;

namespace SigletonPattern.Sigleton
{
	/// <summary>
	/// ���ܣ���C#��˫������ʵ�ֵ���ģʽ
	/// ��д��Terrylee
	/// ���ڣ�2005��12��06��
	/// </summary>
	public class DoubLockSigleton
	{	

		private static volatile DoubLockSigleton instance;
		
		/// <summary>
		/// ���������󣬱���û������ 
		/// </summary>
		private static object syncRoot = new Object();

		/// <summary>
		/// ���췽����ΪPrivate
		/// </summary>
		private DoubLockSigleton()
		{
			
		}

		public static DoubLockSigleton Instance
		{
			get 
			{
				if (instance == null) 
				{
					lock (syncRoot) 
					{
						if (instance == null) 
							instance = new DoubLockSigleton();
					}
				}

				return instance;
			}
		}

	}
}
