using Gios.Word;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Font = System.Drawing.Font;

namespace GraphicsPathsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 修改页面绘制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            int x = ID;
            int s = es;
        }

        /// <summary>
        /// 格式一样式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStyle1_Click(object sender, EventArgs e)
        {
            GraphicsPath _GP = new GraphicsPath();
            _GP.AddLine(0, 0, 0, 300);
            _GP.AddBezier(new PointF(0, 300), new PointF(100, 325), new PointF(200, 325), new PointF(300, 300));
            _GP.AddLine(0, 0, 300, 0);
            _GP.AddLine(300, 0, 300, 300);
            _GP.CloseFigure();
            Region _BaseRegion = new Region(_GP);
            this.Region = _BaseRegion;
        }

        /// <summary>
        /// 格式二样式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStyle2_Click(object sender, EventArgs e)
        {
            GraphicsPath _GP = new GraphicsPath();
            _GP.AddEllipse(new RectangleF(10, 10, 400, 260));
            _GP.AddEllipse(new RectangleF(300, 0, 260, 400));
            _GP.AddEllipse(new RectangleF(300, 20, 40, 100));
            //_GP.CloseFigure();
            Region _BaseRegion = new Region(_GP);
            this.Region = _BaseRegion;
        }

        /// <summary>
        /// 格式三样式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStyle3_Click(object sender, EventArgs e)
        {
            GraphicsPath _GP = new GraphicsPath();
            #region 绘制图形一
            _GP.AddLine(0, 0, 0, 300);
            _GP.AddBezier(new PointF(0, 300), new PointF(100, 325), new PointF(200, 325), new PointF(300, 300));
            _GP.AddLine(0, 0, 300, 0);
            _GP.AddLine(300, 0, 300, 300);
            _GP.CloseFigure();
            #endregion

            #region 绘制图形二
            _GP.StartFigure();
            _GP.AddLine(50, 0, 150, 0);
            _GP.AddLine(new PointF(50, 0), new PointF(50, 150));
            _GP.AddLine(150, 0, 150, 150);
            _GP.AddLine(50, 150, 150, 150);
            _GP.CloseFigure();
            #endregion
            Region _BaseRegion = new Region(_GP);
            this.Region = _BaseRegion;
        }

        /// <summary>
        /// 格式四样式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStyle4_Click(object sender, EventArgs e)
        {
            GraphicsPath _GP = new GraphicsPath();
            #region 绘制图形一
            _GP.AddLine(0, 0, 0, 300);
            _GP.AddBezier(new PointF(0, 300), new PointF(100, 325), new PointF(200, 325), new PointF(300, 300));
            _GP.AddLine(0, 0, 300, 0);
            _GP.AddLine(300, 0, 300, 300);
            _GP.CloseFigure();
            #endregion
            GraphicsPath _GP2 = new GraphicsPath();
            #region 重叠图形二
            //_GP2.StartFigure();
            _GP2.AddLine(50, 0, 150, 0);
            _GP2.AddLine(new PointF(50, 0), new PointF(50, 150));
            _GP2.AddLine(150, 0, 150, 150);
            _GP2.AddLine(50, 150, 150, 150);
            _GP2.CloseFigure();
            #endregion
            Region _BaseRegion = new Region(_GP);
            Region _OverlapRegion = new Region(_GP2);
            //_BaseRegion.Intersect(_OverlapRegion);//全部都存在范围内
            //_BaseRegion.Union(_OverlapRegion);//任意一个图形在范围内
            //_BaseRegion.Xor(_OverlapRegion);//没有同时包含在两图形
            //_BaseRegion.Complement(_OverlapRegion);//保留下右侧参数中不在左侧参数中的范围
            //_BaseRegion.Exclude(_OverlapRegion);//保留下左侧参数中不在右侧参数中的范围
            this.Region = _BaseRegion;
        }

        private void u_Graphics1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("点击控件");
        }

        //生成word文档
        private void mnuCreateWord_ItemClick(object sender)
        {

            string message = "";
            try
            {
                Object oMissing = System.Reflection.Missing.Value;
                string dir = "C:/Documents and Settings/Administrator/桌面";
                string name = DateTime.Now.ToLongDateString() + ".doc";
                object filename = dir + "/" + name; //文件保存路径
                                                    //创建Word文档
                message = name + "文档生成成功";
            }
            catch (Exception ex)
            {
                message = "文件导出异常！";
                MessageBox.Show("导出出错：" + ex.Message);
            }
            MessageBox.Show(message);

        }
        /// <summary>
        /// 打印成绩单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string Path = SetSaveFilePath();
            if (!string.IsNullOrEmpty(Path))
            {
                Gios.Word.WordDocument rd = new WordDocument(WordDocumentFormat.A4_Horizontal);

                Font bold = new Font("宋体", 12, FontStyle.Bold);
                rd.SetFont(bold);
                rd.WriteRtf(richTextBox1.Rtf);

                rd.HeaderStart();
                rd.SetTextAlign(WordTextAlign.Center);
                rd.SetFont(new Font("黑体", 10, FontStyle.Bold));
                rd.Write("第一届世界职业院校技能大赛-轨道交通驾驶技术赛项评分表 - http://www.chinaskills-jsw.org/");
                rd.WriteLine();
                rd.HeaderEnd();

                rd.FooterStart();
                rd.SetTextAlign(WordTextAlign.Center);
                rd.SetFont(new Font("黑体", 10, FontStyle.Bold));
                rd.Write("Copyright © 2013-2022  - 智联友道 All rigths reserved");
                rd.FooterEnd();

                System.IO.FileStream f = System.IO.File.Create(Path, richTextBox1.Rtf.Length, System.IO.FileOptions.Asynchronous);
                rd.SaveToStream(f);
                f.Close();
                f.Dispose();
                System.Diagnostics.Process.Start(Path);
            }
        }

        /// <summary>
        /// 选择文件保存的路径
        /// </summary>
        /// <param name="filterType"></param>
        /// <param name="fileName"></param>
        /// <param name="defaultExt"></param>
        /// <returns></returns>
        public static string SetSaveFilePath(string fileName = "成绩单", string filterType = "Word文档|*.doc", string defaultExt = ".doc")
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = filterType;       //设置文件类型
            dialog.FileName = fileName;                               //设置默认文件名
            dialog.DefaultExt = defaultExt;                              //设置默认格式（可以不设）
            dialog.AddExtension = true;                             //设置自动在文件名中添加扩展名
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                return dialog.FileName;
            }
            return string.Empty;
        }


    }
}
