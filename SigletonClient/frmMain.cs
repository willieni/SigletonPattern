using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Text;
using System.Threading;

///������ƿռ�
using SigletonPattern.Sigleton;

namespace SigletonPattern.SigletonClient
{
	/// <summary>
	/// ���ܣ�����ģʽ��ʾ�������
	/// ��д��Terrylee
	/// ���ڣ�2005��12��06��
	/// </summary>
	public class frmMain : System.Windows.Forms.Form
	{
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RichTextBox rtb_Result;
		private System.Windows.Forms.Button btn_Exit;
		private System.Windows.Forms.Button btn_CommonSigleton;
		private System.Windows.Forms.Button btn_DoubLockSigleton;
		private System.Windows.Forms.Button btn_DotNetSigleton;
		private System.Windows.Forms.Button btn_NoSigleton;
		private System.Windows.Forms.Button btn_CountSigleton;
        private Button btn_DelaySigleton;	

		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmMain()
		{
			//
			// Windows ���������֧���������
			//
			InitializeComponent();

			//
			// TODO: �� InitializeComponent ���ú�����κι��캯������
			//
		}

		/// <summary>
		/// ������������ʹ�õ���Դ��
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows ������������ɵĴ���
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtb_Result = new System.Windows.Forms.RichTextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_CommonSigleton = new System.Windows.Forms.Button();
            this.btn_DoubLockSigleton = new System.Windows.Forms.Button();
            this.btn_DotNetSigleton = new System.Windows.Forms.Button();
            this.btn_NoSigleton = new System.Windows.Forms.Button();
            this.btn_CountSigleton = new System.Windows.Forms.Button();
            this.btn_DelaySigleton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(288, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 64);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("����", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(552, 80);
            this.label1.TabIndex = 1;
            this.label1.Text = " ����ģʽ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rtb_Result
            // 
            this.rtb_Result.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.rtb_Result.Location = new System.Drawing.Point(128, 88);
            this.rtb_Result.Name = "rtb_Result";
            this.rtb_Result.Size = new System.Drawing.Size(424, 232);
            this.rtb_Result.TabIndex = 2;
            this.rtb_Result.Text = "";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(477, 342);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 32);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_CommonSigleton
            // 
            this.btn_CommonSigleton.Location = new System.Drawing.Point(8, 136);
            this.btn_CommonSigleton.Name = "btn_CommonSigleton";
            this.btn_CommonSigleton.Size = new System.Drawing.Size(112, 40);
            this.btn_CommonSigleton.TabIndex = 4;
            this.btn_CommonSigleton.Text = "CommonSigleton";
            this.btn_CommonSigleton.Click += new System.EventHandler(this.btn_CommonSigleton_Click);
            // 
            // btn_DoubLockSigleton
            // 
            this.btn_DoubLockSigleton.Location = new System.Drawing.Point(8, 184);
            this.btn_DoubLockSigleton.Name = "btn_DoubLockSigleton";
            this.btn_DoubLockSigleton.Size = new System.Drawing.Size(112, 40);
            this.btn_DoubLockSigleton.TabIndex = 5;
            this.btn_DoubLockSigleton.Text = "DoubLockSigleton";
            this.btn_DoubLockSigleton.Click += new System.EventHandler(this.btn_DoubLockSigleton_Click);
            // 
            // btn_DotNetSigleton
            // 
            this.btn_DotNetSigleton.Location = new System.Drawing.Point(8, 232);
            this.btn_DotNetSigleton.Name = "btn_DotNetSigleton";
            this.btn_DotNetSigleton.Size = new System.Drawing.Size(112, 40);
            this.btn_DotNetSigleton.TabIndex = 6;
            this.btn_DotNetSigleton.Text = "DotNetSigleton";
            this.btn_DotNetSigleton.Click += new System.EventHandler(this.btn_DotNetSigleton_Click);
            // 
            // btn_NoSigleton
            // 
            this.btn_NoSigleton.Location = new System.Drawing.Point(8, 88);
            this.btn_NoSigleton.Name = "btn_NoSigleton";
            this.btn_NoSigleton.Size = new System.Drawing.Size(112, 40);
            this.btn_NoSigleton.TabIndex = 7;
            this.btn_NoSigleton.Text = "NoSigleton";
            this.btn_NoSigleton.Click += new System.EventHandler(this.btn_NoSigleton_Click);
            // 
            // btn_CountSigleton
            // 
            this.btn_CountSigleton.Location = new System.Drawing.Point(8, 280);
            this.btn_CountSigleton.Name = "btn_CountSigleton";
            this.btn_CountSigleton.Size = new System.Drawing.Size(112, 40);
            this.btn_CountSigleton.TabIndex = 8;
            this.btn_CountSigleton.Text = "CountSigleton";
            this.btn_CountSigleton.Click += new System.EventHandler(this.btn_CommonSigleton_Click);
            // 
            // btn_DelaySigleton
            // 
            this.btn_DelaySigleton.Location = new System.Drawing.Point(8, 332);
            this.btn_DelaySigleton.Name = "btn_DelaySigleton";
            this.btn_DelaySigleton.Size = new System.Drawing.Size(112, 42);
            this.btn_DelaySigleton.TabIndex = 9;
            this.btn_DelaySigleton.Text = "DelaySigleton";
            this.btn_DelaySigleton.UseVisualStyleBackColor = true;
            this.btn_DelaySigleton.Click += new System.EventHandler(this.btn_DelaySigleton_Click);
            // 
            // frmMain
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(583, 386);
            this.Controls.Add(this.btn_DelaySigleton);
            this.Controls.Add(this.btn_CountSigleton);
            this.Controls.Add(this.btn_NoSigleton);
            this.Controls.Add(this.btn_DotNetSigleton);
            this.Controls.Add(this.btn_DoubLockSigleton);
            this.Controls.Add(this.btn_CommonSigleton);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.rtb_Result);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "SigletonPatternʾ������";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// Ӧ�ó��������ڵ㡣
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmMain());
		}
		
		/// <summary>
		/// ��ʾ���
		/// </summary>
		/// <param name="strResult"></param>
		private void UpdateResult(string strResult)
		{
			this.rtb_Result.Text = strResult;
		}

		/// <summary>
		/// �˳�
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_Exit_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}
		
		/// <summary>
		/// ���õ���ģʽ
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_NoSigleton_Click(object sender, System.EventArgs e)
		{
			NoSigleton s1 = new NoSigleton();
			NoSigleton s2 = new NoSigleton();

			string strResult = "";
			if(s1.Equals(s2))
			{
                strResult = "[NoSigleton]the same instance";
			}
			else
			{
                strResult = "[NoSigleton]the defferent instance";
			}

			UpdateResult(strResult);
		}

		/// <summary>
		/// �򵥵�Sigleton
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_CommonSigleton_Click(object sender, System.EventArgs e)
		{
			CommonSigleton s1 = CommonSigleton.Instance;
			CommonSigleton s2 = CommonSigleton.Instance;
			
			string strResult = "";
			if(s1.Equals(s2))
			{
                strResult = "[CommonSigleton]the same instance";
			}
			else
			{
                strResult = "[CommonSigleton]the defferent instance";
			}

			UpdateResult(strResult);
		}
		
		/// <summary>
		/// ˫������Sigleton
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_DoubLockSigleton_Click(object sender, System.EventArgs e)
		{
			DoubLockSigleton s1 = DoubLockSigleton.Instance;
			DoubLockSigleton s2 = DoubLockSigleton.Instance;
			
			string strResult = "";
			if(s1.Equals(s2))
			{
                strResult = "[DoubLockSigleton]the same instance";
			}
			else
			{
                strResult = "[DoubLockSigleton]the defferent instance";
			}

			UpdateResult(strResult);
		}
		
		/// <summary>
		/// ����DotNet���Ե�Sigleton
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_DotNetSigleton_Click(object sender, System.EventArgs e)
		{
			DotNetSigleton s1 = DotNetSigleton.Instance;
			DotNetSigleton s2 = DotNetSigleton.Instance;
			
			string strResult = "";
			if(s1.Equals(s2))
			{
                strResult = "[DotNetSigleton]the same instance";
			}
			else
			{
                strResult = "[DotNetSigleton]the defferent instance";
			}

			UpdateResult(strResult);
		}

        private void btn_DelaySigleton_Click(object sender, EventArgs e)
        {
            DelaySigleton s1 = DelaySigleton.Instance;
            DelaySigleton s2 = DelaySigleton.Instance;

            string strResult = "";
            if (s1.Equals(s2))
            {
                strResult = "[DelaySigleton]the same instance";
            }
            else
            {
                strResult = "[DelaySigleton]the defferent instance";
            }

            UpdateResult(strResult);
        }
		
	}
}
