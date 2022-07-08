using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GraphicsPathsDemo
{
    /// <summary>
    /// 重新绘制页面
    /// </summary>
    public partial class U_Graphics : UserControl
    {
        public U_Graphics()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 绘制等边三角形
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void U_Graphics_Load(object sender, EventArgs e)
        {
            GraphicsPath _GP = new GraphicsPath();
            _GP.AddLine(60, 10,10, 60);
            //_GP.AddBezier(new PointF(0, 300), new PointF(100, 325), new PointF(200, 325), new PointF(300, 300));
            _GP.AddLine(10, 60, 10, 110);
            _GP.AddLine(10, 110, 60, 10);
            _GP.CloseFigure();
            Region _BaseRegion = new Region(_GP);
            this.Region = _BaseRegion;
            //this.Region
        }
    }
}
