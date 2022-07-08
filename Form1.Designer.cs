
namespace GraphicsPathsDemo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStyle1 = new System.Windows.Forms.Button();
            this.btnStyle2 = new System.Windows.Forms.Button();
            this.btnStyle3 = new System.Windows.Forms.Button();
            this.btnStyle4 = new System.Windows.Forms.Button();
            this.u_Graphics1 = new GraphicsPathsDemo.U_Graphics();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStyle1
            // 
            this.btnStyle1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStyle1.Location = new System.Drawing.Point(12, 12);
            this.btnStyle1.Name = "btnStyle1";
            this.btnStyle1.Size = new System.Drawing.Size(92, 25);
            this.btnStyle1.TabIndex = 0;
            this.btnStyle1.Text = "格式一";
            this.btnStyle1.UseVisualStyleBackColor = true;
            this.btnStyle1.Click += new System.EventHandler(this.btnStyle1_Click);
            // 
            // btnStyle2
            // 
            this.btnStyle2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStyle2.Location = new System.Drawing.Point(12, 43);
            this.btnStyle2.Name = "btnStyle2";
            this.btnStyle2.Size = new System.Drawing.Size(92, 25);
            this.btnStyle2.TabIndex = 1;
            this.btnStyle2.Text = "格式二";
            this.btnStyle2.UseVisualStyleBackColor = true;
            this.btnStyle2.Click += new System.EventHandler(this.btnStyle2_Click);
            // 
            // btnStyle3
            // 
            this.btnStyle3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStyle3.Location = new System.Drawing.Point(12, 74);
            this.btnStyle3.Name = "btnStyle3";
            this.btnStyle3.Size = new System.Drawing.Size(92, 25);
            this.btnStyle3.TabIndex = 2;
            this.btnStyle3.Text = "格式三";
            this.btnStyle3.UseVisualStyleBackColor = true;
            this.btnStyle3.Click += new System.EventHandler(this.btnStyle3_Click);
            // 
            // btnStyle4
            // 
            this.btnStyle4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStyle4.Location = new System.Drawing.Point(12, 105);
            this.btnStyle4.Name = "btnStyle4";
            this.btnStyle4.Size = new System.Drawing.Size(92, 25);
            this.btnStyle4.TabIndex = 3;
            this.btnStyle4.Text = "格式五";
            this.btnStyle4.UseVisualStyleBackColor = true;
            this.btnStyle4.Click += new System.EventHandler(this.btnStyle4_Click);
            // 
            // u_Graphics1
            // 
            this.u_Graphics1.BackColor = System.Drawing.Color.Black;
            this.u_Graphics1.Location = new System.Drawing.Point(166, 74);
            this.u_Graphics1.Name = "u_Graphics1";
            this.u_Graphics1.Size = new System.Drawing.Size(334, 247);
            this.u_Graphics1.TabIndex = 4;
            this.u_Graphics1.Click += new System.EventHandler(this.u_Graphics1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(273, 90);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(284, 231);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "打印";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 352);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.u_Graphics1);
            this.Controls.Add(this.btnStyle4);
            this.Controls.Add(this.btnStyle3);
            this.Controls.Add(this.btnStyle2);
            this.Controls.Add(this.btnStyle1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStyle1;
        private System.Windows.Forms.Button btnStyle2;
        private System.Windows.Forms.Button btnStyle3;
        private System.Windows.Forms.Button btnStyle4;
        private U_Graphics u_Graphics1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
    }
}

