//**********************************************************************
//
// 文件名称(File Name)：
// 功能描述(Description)：
// 作者(Author)：DAtoTA
// 日期(Create Date)： 2021/9/12 18:33:59
//
//**********************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using PLC通讯基础控件项目.控件类基.PLC基础接口;
using PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类;
using PLC通讯基础控件项目.控件类基.控件地址选择窗口;
using PLC通讯基础控件项目.控件类基.控件数据结构;
using Sunny.UI;
using PLC通讯基础控件项目.基础控件.底层PLC状态监控控件;

namespace PLC通讯基础控件项目.基础控件
{
    /// <summary>
    /// 实现上位机底层控件 透明按钮类 -不再公共运行时
    /// 继承接口PLCBitClassBase,PLCBitproperty, ICloneable
    /// </summary>
    public partial class DAImageButton
    {
        public DAImageButton()
        {
            SetDefaultControlStyles();
            SuspendLayout();
            base.BorderStyle = BorderStyle.None;
            ResumeLayout(performLayout: false);
            base.Width = 100;
            base.Height = 35;
            Version = UIGlobal.Version;
            Cursor = Cursors.Hand;
            base.Font = UIFontColor.Font;
            Timerconfiguration.Tick += ((send, e) =>
            {
                Timerconfiguration.Stop();
                //处理PLC通讯部分
                if (!this.PLC_Enable || this.IsDisposed || this.Created == false|| DesignMode) return;//用户不开启PLC功能
                {
                    //ControlDebug.Write($"开始加载：{this.Name}控件 归属PLC是：{this.pLCBitselectRealize.ReadWritePLC}");
                    ControlPLCBitBase controlPLCBitBase = new ControlPLCBitBase(this);
                    //ControlDebug.Write($"加载完成：{this.Name}控件 归属PLC是：{this.pLCBitselectRealize.ReadWritePLC}");
                }
                //立马刷新状态
                this.SuspendLayout();
                this.backgroundColor_0 = this.pLCBitselectRealize.backgroundColor_0;
                this.TextContent_0 = this.pLCBitselectRealize.TextContent_0;
                this.TextColor_0 = this.pLCBitselectRealize.TextColor_0;
                this.Refresh();
                this.ResumeLayout(false);
            });
        }
    }
    [ToolboxItem(true)]
    [Browsable(true)]
    [Description("实现上位机底层控件 透明按钮类 -不再公共运行时")]
    public partial class DAImageButton:PictureBox, PLCBitClassBase, PLCBitproperty, ICloneable
    {
        #region 实现接口参数
        [Browsable(false)]
        public event EventHandler Modification;
        [Browsable(false)]
        [Description("PLC保存参数"), Category("PLC类型")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PLCBitselectRealize pLCBitselectRealize
        {
            get => pLCBitselectsq;
            set => pLCBitselectsq = value;
        }
        /// <summary>
        /// 私有保存参数 自动添加
        /// </summary>
        private PLCBitselectRealize pLCBitselectsq { get; set; } = new PLCBitselectRealize();
        [Description("选择PLC类型\r\n默认三菱PLC"), Category("PLC类型")]
        [Browsable(true)]
        public PLCSet APLC
        {
            get => PLCsz;
            set
            {
                if (plc_Enable)
                {
                    this.Modification += new EventHandler(Modifications_Eeve);
                    this.Modification(this, new EventArgs());
                    this.Modification -= new EventHandler(Modifications_Eeve);
                    return;
                }
                this.Modification -= new EventHandler(Modifications_Eeve);
            }

        }
        /// <summary>
        /// 私有设置PLC参数
        /// </summary>
        private PLCSet PLCsz = 0;
        /// <summary>
        /// 是否启用PLC功能
        /// </summary>
        [Browsable(true)]
        [Description("是否启用PLC功能"), Category("PLC类型")]
        public bool PLC_Enable
        {
            get => plc_Enable;
            set => plc_Enable = value;
        }
        private bool plc_Enable = false;
        [Browsable(false)]
        public string Textalign_0
        {
            get
            {
                if (pLCBitselectRealize.Textalign_0 != null)
                    return pLCBitselectRealize.Textalign_0;
                else
                    return ContentAlignment.BottomCenter.ToString();
            }
            set => this.TextAlign = (ContentAlignment)Enum.Parse(typeof(ContentAlignment), value);
        }
        [Browsable(false)]
        public Font TextFont_0 { get => pLCBitselectRealize.TextFont_0; set => this.Font = value; }
        [Browsable(false)]
        public string Textalign_1
        {
            get
            {
                if (pLCBitselectRealize.Textalign_0 != null)
                    return pLCBitselectRealize.Textalign_0;
                else
                    return ContentAlignment.BottomCenter.ToString();
            }
            set => this.TextAlign = (ContentAlignment)Enum.Parse(typeof(ContentAlignment), value);
        }
        [Browsable(false)]
        public Font TextFont_1 { get => pLCBitselectRealize.TextFont_0; set => this.Font = value; }
        [Browsable(false)]
        public Color backgroundColor_0 { get => pLCBitselectRealize.backgroundColor_0; set => this.BackColor = value; }
        [Browsable(false)]
        public Color TextColor_0 { get => pLCBitselectRealize.TextColor_0; set => this.ForeColor = value; }
        [Browsable(false)]
        public string TextContent_0 { get => pLCBitselectRealize.TextContent_0; set => this.Text = value; }
        [Browsable(false)]
        public Color backgroundColor_1 { get => pLCBitselectRealize.backgroundColor_1; set => this.BackColor = value; }
        [Browsable(false)]
        public Color TextColor_1 { get => pLCBitselectRealize.TextColor_1; set => this.ForeColor = value; }
        [Browsable(false)]
        public string TextContent_1 { get => pLCBitselectRealize.TextContent_1; set => this.Text = value; }
        [Browsable(false)]
        public System.Threading.Timer PLCTimer { get; set; }
        public System.Windows.Forms.Timer Timerconfiguration { get; set; } = new System.Windows.Forms.Timer() { Enabled = true, Interval = 100 };

        /// <summary>
        /// 修改参数界面窗口事件方法
        /// </summary>
        /// <param name="send"></param>
        /// <param name="e"></param>

        public  void Modifications_Eeve(object send, EventArgs e)
        {
            this.Modification -= new EventHandler(Modifications_Eeve);
            var Copy = this.pLCBitselectRealize.GetType().GetProperties();
            PLCBitselectRealize bitselectRealize = new PLCBitselectRealize();
            var CopyTo = bitselectRealize.GetType().GetProperties();
            for (int i = 0; i < Copy.Length; i++)
            {
                //if (Copy[i].Name == CopyTo[i].Name)
                CopyTo[i] = Copy[i];
            }
            this.BeginInvoke((MethodInvoker)delegate
            {
                PLCpropertyBit pLCpropertyBit = new PLCpropertyBit(this.pLCBitselectRealize);
                pLCpropertyBit.StartPosition = FormStartPosition.CenterParent;
                pLCpropertyBit.ShowDialog();
                if (!pLCpropertyBit.Save)
                {
                    for (int i = 0; i < Copy.Length; i++)
                    {
                        //if (Copy[i].Name == CopyTo[i].Name)
                        Copy[i] = CopyTo[i];
                    }
                    //this.pLCBitselectRealize = bitselectRealize;
                }
            });
            //立马刷新状态
            this.SuspendLayout();
            this.backgroundColor_0 = this.pLCBitselectRealize.backgroundColor_0;
            this.TextContent_0 = this.pLCBitselectRealize.TextContent_0;
            this.TextColor_0 = this.pLCBitselectRealize.TextColor_0;
            this.Refresh();
            this.ResumeLayout(false);
        }
        /// <summary>
        /// 复制控件方法
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return this;
        }

        public void ControlSwitch(bool switchover)
        {
            if (switchover)
            {
                //立马刷新状态
                this.SuspendLayout();
                this.backgroundColor_0 = this.pLCBitselectRealize.backgroundColor_1;
                this.TextContent_0 = this.pLCBitselectRealize.TextContent_1;
                this.TextColor_0 = this.pLCBitselectRealize.TextColor_1;
                this.Refresh();
                this.ResumeLayout(false);
            }
            else
            {
                //立马刷新状态
                this.SuspendLayout();
                this.backgroundColor_0 = this.pLCBitselectRealize.backgroundColor_0;
                this.TextContent_0 = this.pLCBitselectRealize.TextContent_0;
                this.TextColor_0 = this.pLCBitselectRealize.TextColor_0;
                this.Refresh();
                this.ResumeLayout(false);
            }
        }
        #endregion
        #region 编辑模式刷新状态
        protected override void OnLayout(LayoutEventArgs levent)
        {
            if (DesignMode)
            {
                //立马刷新状态
                this.SuspendLayout();
                this.backgroundColor_0 = this.pLCBitselectRealize.backgroundColor_0;
                this.TextContent_0 = this.pLCBitselectRealize.TextContent_0;
                this.TextColor_0 = this.pLCBitselectRealize.TextColor_0;
                this.Refresh();
                this.ResumeLayout(false);
            }
            base.OnLayout(levent);
        }
        #endregion
    }
    public partial class DAImageButton
    {
        private bool IsPress;

        private bool IsHover;

        private Image imageDisabled;

        private Image imagePress;

        private Image imageHover;

        private Image imageSelected;

        private bool selected;

        private string text;

        private ContentAlignment textAlign = ContentAlignment.MiddleCenter;

        private Color foreColor = UIFontColor.Primary;

        public Point imageOffset;

        [DefaultValue(null)]
        [Description("获取或设置包含有关控件的数据的对象字符串")]
        [Category("DAImageButton")]
        public string TagString
        {
            get;
            set;
        }

        [Category("DAImageButton")]
        [Description("按钮文字")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text
        {
            get
            {
                return text;
            }
            set
            {
                if (text != value)
                {
                    text = value;
                    Invalidate();
                }
            }
        }

        [Description("文字对齐方式")]
        [Category("DAImageButton")]
        [DefaultValue(ContentAlignment.MiddleCenter)]
        public ContentAlignment TextAlign
        {
            get
            {
                return textAlign;
            }
            set
            {
                textAlign = value;
                Invalidate();
            }
        }

        [Category("DAImageButton")]
        [Description("文字字体")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override Font Font
        {
            get
            {
                return base.Font;
            }
            set
            {
                base.Font = value;
                Invalidate();
            }
        }

        [Category("DAImageButton")]
        [Description("文字颜色")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(typeof(Color), "48, 48, 48")]
        public override Color ForeColor
        {
            get
            {
                return foreColor;
            }
            set
            {
                foreColor = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        [DefaultValue(typeof(Image), "null")]
        [Description("初始化图片")]
        [Category("DAImageButton")]
        public new Image InitialImage
        {
            get;
            set;
        }

        [Browsable(false)]
        [DefaultValue(typeof(Image), "null")]
        [Description("出错图片")]
        [Category("DAImageButton")]
        public new Image ErrorImage
        {
            get;
            set;
        }

        public string Version
        {
            get;
        }

        [DefaultValue(typeof(Image), "null")]
        [Description("鼠标移上图片")]
        [Category("DAImageButton")]
        public Image ImageHover
        {
            get
            {
                return imageHover;
            }
            set
            {
                imageHover = value;
                Invalidate();
            }
        }

        [DefaultValue(typeof(Image), "null")]
        [Description("鼠标按下图片")]
        [Category("DAImageButton")]
        public Image ImagePress
        {
            get
            {
                return imagePress;
            }
            set
            {
                imagePress = value;
                Invalidate();
            }
        }

        [DefaultValue(typeof(Image), "null")]
        [Description("不可用时图片")]
        [Category("DAImageButton")]
        public Image ImageDisabled
        {
            get
            {
                return imageDisabled;
            }
            set
            {
                imageDisabled = value;
                Invalidate();
            }
        }

        [DefaultValue(typeof(Image), "null")]
        [Description("选中时图片")]
        [Category("DAImageButton")]
        public Image ImageSelected
        {
            get
            {
                return imageSelected;
            }
            set
            {
                imageSelected = value;
                Invalidate();
            }
        }

        [DefaultValue(typeof(bool), "false")]
        [Description("是否选中")]
        [Category("DAImageButton")]
        public bool Selected
        {
            get
            {
                return selected;
            }
            set
            {
                if (selected != value)
                {
                    selected = value;
                    Invalidate();
                }
            }
        }

        [DefaultValue(typeof(Point), "0, 0")]
        [Description("图片偏移位置")]
        [Category("DAImageButton")]
        public Point ImageOffset
        {
            get
            {
                return imageOffset;
            }
            set
            {
                imageOffset = value;
                Invalidate();
            }
        }

        private void SetDefaultControlStyles()
        {
            SetStyle(ControlStyles.UserPaint, value: true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, value: true);
            SetStyle(ControlStyles.DoubleBuffer, value: true);
            UpdateStyles();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            IsPress = true;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            IsPress = false;
            Invalidate();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            if (!base.DesignMode)
            {
                Cursor = Cursors.Hand;
            }

            IsHover = true;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            IsHover = false;
            IsPress = false;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            Image image = base.Image;
            if (!base.Enabled)
            {
                image = imageDisabled;
            }
            else
            {
                if (IsPress)
                {
                    image = imagePress;
                }
                else if (IsHover)
                {
                    image = imageHover;
                }

                if (Selected)
                {
                    image = imageSelected;
                }
            }

            if (image == null)
            {
                image = base.Image;
            }

            if (image != null)
            {
                if (base.SizeMode == PictureBoxSizeMode.Normal)
                {
                    pe.Graphics.DrawImage(image, new Rectangle(ImageOffset.X, ImageOffset.Y, image.Width, image.Height));
                }

                if (base.SizeMode == PictureBoxSizeMode.StretchImage)
                {
                    pe.Graphics.DrawImage(image, new Rectangle(0, 0, base.Width, base.Height));
                }

                if (base.SizeMode == PictureBoxSizeMode.AutoSize)
                {
                    base.Width = image.Width;
                    base.Height = image.Height;
                    pe.Graphics.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height));
                }

                if (base.SizeMode == PictureBoxSizeMode.Zoom)
                {
                    pe.Graphics.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height));
                }

                if (base.SizeMode == PictureBoxSizeMode.CenterImage)
                {
                    pe.Graphics.DrawImage(image, new Rectangle((base.Width - image.Width) / 2, (base.Height - image.Height) / 2, image.Width, image.Height));
                }
            }
            else
            {
                base.OnPaint(pe);
            }

            SizeF sizeF = pe.Graphics.MeasureString(Text, Font);
            switch (TextAlign)
            {
                case ContentAlignment.TopLeft:
                    pe.Graphics.DrawString(text, Font, ForeColor, base.Padding.Left, base.Padding.Top);
                    break;
                case ContentAlignment.TopCenter:
                    pe.Graphics.DrawString(text, Font, ForeColor, ((float)base.Width - sizeF.Width) / 2f, base.Padding.Top);
                    break;
                case ContentAlignment.TopRight:
                    pe.Graphics.DrawString(text, Font, ForeColor, (float)(base.Width - base.Padding.Right) - sizeF.Width, base.Padding.Top);
                    break;
                case ContentAlignment.MiddleLeft:
                    pe.Graphics.DrawString(text, Font, ForeColor, base.Padding.Left, ((float)base.Height - sizeF.Height) / 2f);
                    break;
                case ContentAlignment.MiddleCenter:
                    pe.Graphics.DrawString(text, Font, ForeColor, ((float)base.Width - sizeF.Width) / 2f, ((float)base.Height - sizeF.Height) / 2f);
                    break;
                case ContentAlignment.MiddleRight:
                    pe.Graphics.DrawString(text, Font, ForeColor, (float)(base.Width - base.Padding.Right) - sizeF.Width, ((float)base.Height - sizeF.Height) / 2f);
                    break;
                case ContentAlignment.BottomLeft:
                    pe.Graphics.DrawString(text, Font, ForeColor, base.Padding.Left, (float)(base.Height - base.Padding.Bottom) - sizeF.Height);
                    break;
                case ContentAlignment.BottomCenter:
                    pe.Graphics.DrawString(text, Font, ForeColor, ((float)base.Width - sizeF.Width) / 2f, (float)(base.Height - base.Padding.Bottom) - sizeF.Height);
                    break;
                case ContentAlignment.BottomRight:
                    pe.Graphics.DrawString(text, Font, ForeColor, (float)(base.Width - base.Padding.Right) - sizeF.Width, (float)(base.Height - base.Padding.Bottom) - sizeF.Height);
                    break;
            }
        }

    }
}
