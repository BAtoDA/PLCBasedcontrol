//**********************************************************************
//
// 文件名称(File Name)：
// 功能描述(Description)：
// 作者(Author)：DAtoTA
// 日期(Create Date)： 2021/9/12 20:58:23
//
//**********************************************************************
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using PLC通讯基础控件项目.基础控件.底层PLC状态监控控件;
using PLC通讯基础控件项目.控件类基.PLC基础接口;
using PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLCD控件实现类;
using PLC通讯基础控件项目.控件类基.控件地址选择窗口;
using PLC通讯基础控件项目.控件类基.控件数据结构;
using Sunny.UI;
using Sunny.UI.Win32;

namespace PLC通讯基础控件项目.基础控件
{
    /// <summary>
    /// 实现上位机底层控件 普通文本类 -不再公共运行时
    /// </summary>
    public partial class DAUiTextBox
    {
        public DAUiTextBox()
        {
            InitializeComponent();
            SetStyleFlags();
            CalcEditHeight();
            base.Height = MinHeight;
            base.ShowText = false;
            Font = UIFontColor.Font;
            base.Padding = new Padding(0);
            edit.Top = (base.Height - edit.Height) / 2;
            edit.Left = 4;
            edit.Width = base.Width - 8;
            edit.Text = string.Empty;
            edit.BorderStyle = BorderStyle.None;
            edit.TextChanged += EditTextChanged;
            edit.KeyDown += EditOnKeyDown;
            edit.KeyUp += EditOnKeyUp;
            edit.KeyPress += EditOnKeyPress;
            edit.MouseEnter += Edit_MouseEnter;
            edit.Click += Edit_Click;
            edit.DoubleClick += Edit_DoubleClick;
            edit.Leave += Edit_Leave;
            edit.Validated += Edit_Validated;
            edit.Validating += Edit_Validating;
            edit.GotFocus += Edit_GotFocus;
            edit.LostFocus += Edit_LostFocus;
            edit.Invalidate();
            base.Controls.Add(edit);
            fillColor = Color.White;
            base.Width = 150;
            bar.Parent = this;
            bar.Dock = DockStyle.None;
            bar.Style = UIStyle.Custom;
            bar.Visible = false;
            bar.ValueChanged += Bar_ValueChanged;
            edit.MouseWheel += OnMouseWheel;
            bar.MouseEnter += Bar_MouseEnter;
            base.TextAlignment = ContentAlignment.MiddleLeft;
            SizeChange();
            editCursor = Cursor;
            base.TextAlignmentChange += UITextBox_TextAlignmentChange;
            Timerconfiguration.Tick += ((send, e) =>
            {
                Timerconfiguration.Stop();
                //处理PLC通讯部分
                if (!this.PLC_Enable || this.IsDisposed || this.Created == false) return;//用户不开启PLC功能
                {
                    //ControlDebug.Write($"开始加载：{this.Name}控件 归属PLC是：{this.pLCDselectRealize.ReadWritePLC}");
                    ControlPLCDBase controlPLCDBase = new ControlPLCDBase(this);
                    //ControlDebug.Write($"加载完成：{this.Name}控件 归属PLC是：{this.pLCDselectRealize.ReadWritePLC}");
                }
                //立马刷新状态
                this.SuspendLayout();
                this.TextContent_0 = this.pLCDselectRealize.TextContent_0;
                this.TextColor_0 = this.pLCDselectRealize.TextColor_0;
                this.Refresh();
                this.ResumeLayout(false);
            });
            this.Text = "0";
        }
    }
    [ToolboxItem(true)]
    [Browsable(true)]
    [Description("实现上位机底层控件 普通文本类 -不再公共运行时 ")]
    public partial class DAUiTextBox : UIPanel, PLCDClassBase, PLCDproperty, ICloneable, ISymbol
    {
        #region 实现接口参数
        [Browsable(false)]
        public event EventHandler Modification;
        [Browsable(false)]
        [Description("PLC保存参数"), Category("PLC类型")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PLCDselectRealize pLCDselectRealize
        {
            get => pLCBitselectsq;
            set => pLCBitselectsq = value;
        }
        /// <summary>
        /// 私有保存参数 自动添加
        /// </summary>
        private PLCDselectRealize pLCBitselectsq { get; set; } = new PLCDselectRealize();
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
                if (pLCDselectRealize.Textalign_0 != null)
                    return pLCDselectRealize.Textalign_0;
                else
                    return ContentAlignment.BottomCenter.ToString();
            }
            set => this.TextAlignment = (ContentAlignment)Enum.Parse(typeof(ContentAlignment), value);
        }
        [Browsable(false)]
        public Font TextFont_0 { get => pLCDselectRealize.TextFont_0; set => this.Font = value; }
        [Browsable(false)]
        public string Textalign_1
        {
            get
            {
                if (pLCDselectRealize.Textalign_0 != null)
                    return pLCDselectRealize.Textalign_0;
                else
                    return ContentAlignment.BottomCenter.ToString();
            }
            set => this.TextAlignment = (ContentAlignment)Enum.Parse(typeof(ContentAlignment), value);
        }
        [Browsable(false)]
        public Font TextFont_1 { get => pLCDselectRealize.TextFont_0; set => this.Font = value; }
        [Browsable(false)]
        public Color TextColor_0 { get => pLCDselectRealize.TextColor_0; set => this.ForeColor = value; }
        [Browsable(false)]
        public string TextContent_0 { get => pLCDselectRealize.TextContent_0; set => this.Text = value; }
        [Browsable(false)]
        public Color TextColor_1 { get => pLCDselectRealize.TextColor_1; set => this.ForeColor = value; }
        [Browsable(false)]
        public string TextContent_1 { get => pLCDselectRealize.TextContent_1; set => this.Text = value; }
        [Browsable(false)]
        public System.Threading.Timer PLCTimer { get; set; }
        public System.Windows.Forms.Timer Timerconfiguration { get; set; } = new System.Windows.Forms.Timer() { Enabled = true, Interval = 300 };

        /// <summary>
        /// 修改参数界面窗口事件方法
        /// </summary>
        /// <param name="send"></param>
        /// <param name="e"></param>

        public void Modifications_Eeve(object send, EventArgs e)
        {
            this.Modification -= new EventHandler(Modifications_Eeve);
            var Copy = this.pLCDselectRealize.GetType().GetProperties();
            PLCDselectRealize bitselectRealize = new PLCDselectRealize();
            var CopyTo = bitselectRealize.GetType().GetProperties();
            for (int i = 0; i < Copy.Length; i++)
            {
                //if (Copy[i].Name == CopyTo[i].Name)
                CopyTo[i] = Copy[i];
            }
            PLCpropertyD pLCpropertyBit = new PLCpropertyD(this.pLCDselectRealize);
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
            //立马刷新状态
            this.SuspendLayout();
            this.TextContent_0 = this.pLCDselectRealize.TextContent_0;
            this.TextColor_0 = this.pLCDselectRealize.TextColor_0;
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
        #endregion
    }

    public partial class DAUiTextBox
    {
        public enum UIEditType
        {
            String,
            Integer,
            Double
        }

        internal class TextBoxAutoCompleteSourceConverter : EnumConverter
        {
            public TextBoxAutoCompleteSourceConverter(Type type)
                : base(type)
            {
            }

            public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
            {
                StandardValuesCollection standardValues = base.GetStandardValues(context);
                ArrayList arrayList = new ArrayList();
                int count = standardValues.Count;
                for (int i = 0; i < count; i++)
                {
                    string text = standardValues[i].ToString();
                    if (text != null && !text.Equals("ListItems"))
                    {
                        arrayList.Add(standardValues[i]);
                    }
                }

                return new StandardValuesCollection(arrayList);
            }
        }

        private readonly UIEdit edit = new UIEdit();

        private readonly UIScrollBar bar = new UIScrollBar();

        public new EventHandler GotFocus;

        public new EventHandler LostFocus;

        public new CancelEventHandler Validating;

        private Cursor editCursor;

        private bool multiline;

        private bool showScrollBar;

        private int MinHeight;

        private int MaxHeight;

        private Image icon;

        private int iconSize = 24;

        public Color _symbolColor = UIFontColor.Primary;

        private int _symbol;

        private int _symbolSize = 24;

        private Point symbolOffset = new Point(0, 0);

        private IContainer components;

        [Browsable(false)]
        public TextBox TextBox => edit;

        public override bool Focused => edit.Focused;

        [DefaultValue(false)]
        [Description("激活时选中全部文字")]
        [Category("SunnyUI")]
        public bool FocusedSelectAll
        {
            get
            {
                return edit.FocusedSelectAll;
            }
            set
            {
                edit.FocusedSelectAll = value;
            }
        }

        [DefaultValue(false)]
        public bool Multiline
        {
            get
            {
                return multiline;
            }
            set
            {
                multiline = value;
                edit.Multiline = value;
                if (value && Type != 0)
                {
                    Type = UIEditType.String;
                }

                SizeChange();
            }
        }

        [DefaultValue(false)]
        [Description("显示垂直滚动条")]
        [Category("SunnyUI")]
        public bool ShowScrollBar
        {
            get
            {
                return showScrollBar;
            }
            set
            {
                value = (value && Multiline);
                showScrollBar = value;
                if (value)
                {
                    edit.ScrollBars = ScrollBars.Vertical;
                    bar.Visible = true;
                }
                else
                {
                    edit.ScrollBars = ScrollBars.None;
                    bar.Visible = false;
                }
            }
        }

        [DefaultValue(true)]
        public bool WordWarp
        {
            get
            {
                return edit.WordWrap;
            }
            set
            {
                edit.WordWrap = value;
            }
        }

        [DefaultValue(null)]
        [Description("水印文字")]
        [Category("SunnyUI")]
        public string Watermark
        {
            get
            {
                return edit.Watermark;
            }
            set
            {
                edit.Watermark = value;
            }
        }

        [DefaultValue('\0')]
        [Description("密码掩码")]
        [Category("SunnyUI")]
        public char PasswordChar
        {
            get
            {
                return edit.PasswordChar;
            }
            set
            {
                edit.PasswordChar = value;
            }
        }

        [DefaultValue(false)]
        [Description("是否只读")]
        [Category("SunnyUI")]
        public bool ReadOnly
        {
            get
            {
                return edit.ReadOnly;
            }
            set
            {
                edit.ReadOnly = value;
                edit.BackColor = (base.Enabled ? Color.White : base.FillDisableColor);
            }
        }

        [Description("输入类型")]
        [Category("SunnyUI")]
        [DefaultValue(UIEditType.String)]
        public UIEditType Type
        {
            get
            {
                return (UIEditType)edit.Type;
            }
            set
            {
                edit.Type = (UITextBox.UIEditType)value;
            }
        }

        [Description("当InputType为数字类型时，能输入的最大值。")]
        [Category("SunnyUI")]
        [DefaultValue(int.MaxValue)]
        public double Maximum
        {
            get
            {
                return edit.MaxValue;
            }
            set
            {
                edit.MaxValue = value;
            }
        }

        [Description("当InputType为数字类型时，能输入的最小值。")]
        [Category("SunnyUI")]
        [DefaultValue(int.MinValue)]
        public double Minimum
        {
            get
            {
                return edit.MinValue;
            }
            set
            {
                edit.MinValue = value;
            }
        }

        [DefaultValue(false)]
        [Description("是否判断最大值显示")]
        [Category("SunnyUI")]
        public bool MaximumEnabled
        {
            get
            {
                return HasMaximum;
            }
            set
            {
                HasMaximum = value;
            }
        }

        [DefaultValue(false)]
        [Description("是否判断最小值显示")]
        [Category("SunnyUI")]
        public bool MinimumEnabled
        {
            get
            {
                return HasMinimum;
            }
            set
            {
                HasMinimum = value;
            }
        }

        [DefaultValue(false)]
        [Browsable(false)]
        [Description("是否判断最大值显示")]
        [Category("SunnyUI")]
        public bool HasMaximum
        {
            get
            {
                return edit.HasMaxValue;
            }
            set
            {
                edit.HasMaxValue = value;
            }
        }

        [DefaultValue(false)]
        [Browsable(false)]
        [Description("是否判断最小值显示")]
        [Category("SunnyUI")]
        public bool HasMinimum
        {
            get
            {
                return edit.HasMinValue;
            }
            set
            {
                edit.HasMinValue = value;
            }
        }

        [DefaultValue(0.0)]
        [Description("浮点返回值")]
        [Category("SunnyUI")]
        public double DoubleValue
        {
            get
            {
                return edit.DoubleValue;
            }
            set
            {
                edit.DoubleValue = value;
            }
        }

        [DefaultValue(0)]
        [Description("整形返回值")]
        [Category("SunnyUI")]
        public int IntValue
        {
            get
            {
                return edit.IntValue;
            }
            set
            {
                edit.IntValue = value;
            }
        }

        [Description("文本返回值")]
        [Category("SunnyUI")]
        [Browsable(true)]
        [DefaultValue("")]
        public override string Text
        {
            get
            {
                return edit.Text;
            }
            set
            {
                edit.Text = value;
            }
        }

        [Description("当InputType为数字类型时，小数位数。")]
        [DefaultValue(2)]
        [Category("SunnyUI")]
        public int DecLength
        {
            get
            {
                return edit.DecLength;
            }
            set
            {
                edit.DecLength = Math.Max(value, 0);
            }
        }

        [DefaultValue(false)]
        [Description("整形或浮点输入时，是否可空显示")]
        [Category("SunnyUI")]
        public bool CanEmpty
        {
            get
            {
                return edit.CanEmpty;
            }
            set
            {
                edit.CanEmpty = value;
            }
        }

        public bool IsEmpty => edit.Text == "";

        [DefaultValue(32767)]
        public int MaxLength
        {
            get
            {
                return edit.MaxLength;
            }
            set
            {
                edit.MaxLength = Math.Max(value, 1);
            }
        }

        [DefaultValue(false)]
        public bool AcceptsReturn
        {
            get
            {
                return edit.AcceptsReturn;
            }
            set
            {
                edit.AcceptsReturn = value;
            }
        }

        [DefaultValue(AutoCompleteMode.None)]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteMode AutoCompleteMode
        {
            get
            {
                return edit.AutoCompleteMode;
            }
            set
            {
                edit.AutoCompleteMode = value;
            }
        }

        [DefaultValue(AutoCompleteSource.None)]
        [TypeConverter(typeof(TextBoxAutoCompleteSourceConverter))]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteSource AutoCompleteSource
        {
            get
            {
                return edit.AutoCompleteSource;
            }
            set
            {
                edit.AutoCompleteSource = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Localizable(true)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteStringCollection AutoCompleteCustomSource
        {
            get
            {
                return edit.AutoCompleteCustomSource;
            }
            set
            {
                edit.AutoCompleteCustomSource = value;
            }
        }

        [DefaultValue(CharacterCasing.Normal)]
        public CharacterCasing CharacterCasing
        {
            get
            {
                return edit.CharacterCasing;
            }
            set
            {
                edit.CharacterCasing = value;
            }
        }

        [DefaultValue(false)]
        public bool AcceptsTab
        {
            get
            {
                return edit.AcceptsTab;
            }
            set
            {
                edit.AcceptsTab = value;
            }
        }

        [DefaultValue(false)]
        public bool EnterAsTab
        {
            get
            {
                return edit.EnterAsTab;
            }
            set
            {
                edit.EnterAsTab = value;
            }
        }

        [DefaultValue(true)]
        public bool ShortcutsEnabled
        {
            get
            {
                return edit.ShortcutsEnabled;
            }
            set
            {
                edit.ShortcutsEnabled = value;
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool CanUndo => edit.CanUndo;

        [DefaultValue(true)]
        public bool HideSelection
        {
            get
            {
                return edit.HideSelection;
            }
            set
            {
                edit.HideSelection = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [MergableProperty(false)]
        [Localizable(true)]
        [Editor("System.Windows.Forms.Design.StringArrayEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public string[] Lines
        {
            get
            {
                return edit.Lines;
            }
            set
            {
                edit.Lines = value;
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool Modified
        {
            get
            {
                return edit.Modified;
            }
            set
            {
                edit.Modified = value;
            }
        }

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int PreferredHeight => edit.PreferredHeight;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string SelectedText
        {
            get
            {
                return edit.SelectedText;
            }
            set
            {
                edit.SelectedText = value;
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectionLength
        {
            get
            {
                return edit.SelectionLength;
            }
            set
            {
                edit.SelectionLength = value;
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectionStart
        {
            get
            {
                return edit.SelectionStart;
            }
            set
            {
                edit.SelectionStart = value;
            }
        }

        [Browsable(false)]
        public int TextLength => edit.TextLength;

        [Description("图标")]
        [Category("SunnyUI")]
        [DefaultValue(null)]
        public Image Icon
        {
            get
            {
                return icon;
            }
            set
            {
                icon = value;
                SizeChange();
                Invalidate();
            }
        }

        [Description("图标大小(方形)")]
        [Category("SunnyUI")]
        [DefaultValue(24)]
        public int IconSize
        {
            get
            {
                return iconSize;
            }
            set
            {
                iconSize = Math.Min(MinHeight, value);
                SizeChange();
                Invalidate();
            }
        }

        [DefaultValue(typeof(Color), "48, 48, 48")]
        [Description("字体图标颜色")]
        [Category("SunnyUI")]
        public Color SymbolColor
        {
            get
            {
                return _symbolColor;
            }
            set
            {
                _symbolColor = value;
                Invalidate();
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Editor(typeof(UIImagePropertyEditor), typeof(UITypeEditor))]
        [DefaultValue(0)]
        [Description("字体图标")]
        [Category("SunnyUI")]
        public int Symbol
        {
            get
            {
                return _symbol;
            }
            set
            {
                _symbol = value;
                SizeChange();
                Invalidate();
            }
        }

        [DefaultValue(24)]
        [Description("字体图标大小")]
        [Category("SunnyUI")]
        public int SymbolSize
        {
            get
            {
                return _symbolSize;
            }
            set
            {
                _symbolSize = Math.Max(value, 16);
                _symbolSize = Math.Min(value, MinHeight);
                SizeChange();
                Invalidate();
            }
        }

        [DefaultValue(typeof(Point), "0, 0")]
        [Description("字体图标的偏移位置")]
        [Category("SunnyUI")]
        public Point SymbolOffset
        {
            get
            {
                return symbolOffset;
            }
            set
            {
                symbolOffset = value;
                Invalidate();
            }
        }

        public new event EventHandler Validated;

        public new event EventHandler DoubleClick;

        public new event EventHandler Click;

        public event EventHandler DoEnter;

        [Browsable(true)]
        public new event EventHandler TextChanged;

        public new event KeyEventHandler KeyDown;

        public new event KeyEventHandler KeyUp;

        public new event KeyPressEventHandler KeyPress;

        public new event EventHandler Leave;

        private void Edit_LostFocus(object sender, EventArgs e)
        {
            LostFocus?.Invoke(this, e);
        }

        private void Edit_GotFocus(object sender, EventArgs e)
        {
            GotFocus?.Invoke(this, e);
        }

        private void Edit_Validating(object sender, CancelEventArgs e)
        {
            Validating?.Invoke(this, e);
        }

        private void Edit_Validated(object sender, EventArgs e)
        {
            this.Validated?.Invoke(this, e);
        }

        public new void Focus()
        {
            base.Focus();
            edit.Focus();
        }

        private void Edit_Leave(object sender, EventArgs e)
        {
            this.Leave?.Invoke(this, e);
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
            edit.BackColor = (base.Enabled ? Color.White : base.FillDisableColor);
            edit.Enabled = base.Enabled;
        }

        private void UITextBox_TextAlignmentChange(object sender, ContentAlignment alignment)
        {
            if (edit != null)
            {
                if (alignment == ContentAlignment.TopLeft || alignment == ContentAlignment.MiddleLeft || alignment == ContentAlignment.BottomLeft)
                {
                    edit.TextAlign = HorizontalAlignment.Left;
                }

                if (alignment == ContentAlignment.TopCenter || alignment == ContentAlignment.MiddleCenter || alignment == ContentAlignment.BottomCenter)
                {
                    edit.TextAlign = HorizontalAlignment.Center;
                }

                if (alignment == ContentAlignment.TopRight || alignment == ContentAlignment.MiddleRight || alignment == ContentAlignment.BottomRight)
                {
                    edit.TextAlign = HorizontalAlignment.Right;
                }
            }
        }

        private void Edit_DoubleClick(object sender, EventArgs e)
        {
            this.DoubleClick?.Invoke(this, e);
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            this.Click?.Invoke(this, e);
        }

        protected override void OnCursorChanged(EventArgs e)
        {
            base.OnCursorChanged(e);
            edit.Cursor = Cursor;
        }

        private void Bar_MouseEnter(object sender, EventArgs e)
        {
            editCursor = Cursor;
            Cursor = Cursors.Default;
        }

        private void Edit_MouseEnter(object sender, EventArgs e)
        {
            Cursor = editCursor;
            if (FocusedSelectAll)
            {
                SelectAll();
            }
        }

        private void OnMouseWheel(object sender, MouseEventArgs e)
        {
            OnMouseWheel(e);
            if (bar != null && bar.Visible && edit != null)
            {
                SCROLLINFO info = ScrollBarInfo.GetInfo(edit.Handle);
                if (e.Delta > 10)
                {
                    if (info.nPos > 0)
                    {
                        ScrollBarInfo.ScrollUp(edit.Handle);
                    }
                }
                else if (e.Delta < -10 && info.nPos < info.ScrollMax)
                {
                    ScrollBarInfo.ScrollDown(edit.Handle);
                }
            }

            SetScrollInfo();
        }

        private void Bar_ValueChanged(object sender, EventArgs e)
        {
            if (edit != null)
            {
                ScrollBarInfo.SetScrollValue(edit.Handle, bar.Value);
            }
        }

        public void Select(int start, int length)
        {
            edit.Focus();
            edit.Select(start, length);
        }

        public void ScrollToCaret()
        {
            edit.ScrollToCaret();
        }

        private void EditOnKeyPress(object sender, KeyPressEventArgs e)
        {
            this.KeyPress?.Invoke(this, e);
        }

        private void EditOnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.DoEnter?.Invoke(this, e);
            }

            this.KeyDown?.Invoke(this, e);
        }

        private void EditOnKeyUp(object sender, KeyEventArgs e)
        {
            this.KeyUp?.Invoke(this, e);
        }

        public void SelectAll()
        {
            edit.Focus();
            edit.SelectAll();
        }

        public void CheckMaxMin()
        {
            edit.CheckMaxMin();
        }

        private void EditTextChanged(object s, EventArgs e)
        {
            this.TextChanged?.Invoke(this, e);
            SetScrollInfo();
        }

        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            edit.Font = Font;
            CalcEditHeight();
            SizeChange();
            Invalidate();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            SizeChange();
        }

        protected override void OnPaddingChanged(EventArgs e)
        {
            base.OnPaddingChanged(e);
            SizeChange();
        }

        public void SetScrollInfo()
        {
            if (bar != null)
            {
                SCROLLINFO info = ScrollBarInfo.GetInfo(edit.Handle);
                if (info.ScrollMax > 0)
                {
                    bar.Maximum = info.ScrollMax;
                    bar.Value = info.nPos;
                }
                else
                {
                    bar.Maximum = info.ScrollMax;
                }
            }
        }

        private void CalcEditHeight()
        {
            TextBox textBox = new TextBox();
            textBox.Font = edit.Font;
            MinHeight = textBox.PreferredHeight;
            textBox.BorderStyle = BorderStyle.None;
            MaxHeight = textBox.PreferredHeight * 2 + MinHeight - textBox.PreferredHeight;
            textBox.Dispose();
        }

        private void SizeChange()
        {
            if (!multiline)
            {
                if (base.Height < MinHeight)
                {
                    base.Height = MinHeight;
                }

                if (base.Height > MaxHeight)
                {
                    base.Height = MaxHeight;
                }

                edit.Top = (base.Height - edit.Height) / 2;
                if (icon == null && Symbol == 0)
                {
                    edit.Left = 4 + base.Padding.Left;
                    edit.Width = base.Width - 8 - base.Padding.Left - base.Padding.Right;
                }
                else if (icon != null)
                {
                    edit.Left = 4 + iconSize + base.Padding.Left;
                    edit.Width = base.Width - 8 - iconSize - base.Padding.Left - base.Padding.Right;
                }
                else if (Symbol > 0)
                {
                    edit.Left = 4 + SymbolSize + base.Padding.Left;
                    edit.Width = base.Width - 8 - SymbolSize - base.Padding.Left - base.Padding.Right;
                }
            }
            else
            {
                edit.Top = 3;
                edit.Height = base.Height - 6;
                edit.Left = 1;
                edit.Width = base.Width - 2;
                bar.Top = 2;
                bar.Width = ScrollBarInfo.VerticalScrollBarWidth();
                bar.Left = base.Width - bar.Width - 1;
                bar.Height = base.Height - 4;
                bar.BringToFront();
                SetScrollInfo();
            }
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            edit.Focus();
        }

        public void Clear()
        {
            edit.Clear();
        }

        public void Empty()
        {
            if (edit.CanEmpty)
            {
                edit.Text = "";
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.ActiveControl = edit;
        }

        public override void SetStyleColor(UIBaseStyle uiColor)
        {
            base.SetStyleColor(uiColor);
            edit.BackColor = (fillColor = (base.Enabled ? Color.White : base.FillDisableColor));
            edit.ForeColor = (foreColor = UIFontColor.Primary);
            if (bar != null)
            {
                bar.ForeColor = uiColor.PrimaryColor;
                bar.HoverColor = uiColor.ButtonFillHoverColor;
                bar.PressColor = uiColor.ButtonFillPressColor;
                bar.FillColor = Color.White;
            }

            Invalidate();
        }

        protected override void AfterSetForeColor(Color color)
        {
            base.AfterSetForeColor(color);
            edit.ForeColor = color;
        }

        protected override void AfterSetFillColor(Color color)
        {
            base.AfterSetFillColor(color);
            edit.BackColor = (base.Enabled ? color : base.FillDisableColor);
        }

        public void Paste(string text)
        {
            edit.Paste(text);
        }

        public void AppendText(string text)
        {
            edit.AppendText(text);
        }

        public void ClearUndo()
        {
            edit.ClearUndo();
        }

        public void Copy()
        {
            edit.Copy();
        }

        public void Cut()
        {
            edit.Cut();
        }

        public void Paste()
        {
            edit.Paste();
        }

        public char GetCharFromPosition(Point pt)
        {
            return edit.GetCharFromPosition(pt);
        }

        public int GetCharIndexFromPosition(Point pt)
        {
            return edit.GetCharIndexFromPosition(pt);
        }

        public int GetLineFromCharIndex(int index)
        {
            return edit.GetLineFromCharIndex(index);
        }

        public Point GetPositionFromCharIndex(int index)
        {
            return edit.GetPositionFromCharIndex(index);
        }

        public int GetFirstCharIndexFromLine(int lineNumber)
        {
            return edit.GetFirstCharIndexFromLine(lineNumber);
        }

        public int GetFirstCharIndexOfCurrentLine()
        {
            return edit.GetFirstCharIndexOfCurrentLine();
        }

        public void DeselectAll()
        {
            edit.DeselectAll();
        }

        public void Undo()
        {
            edit.Undo();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (!multiline)
            {
                if (icon != null)
                {
                    e.Graphics.DrawImage(icon, new Rectangle(4, (base.Height - iconSize) / 2, iconSize, iconSize), new Rectangle(0, 0, icon.Width, icon.Height), GraphicsUnit.Pixel);
                }
                else if (Symbol != 0)
                {
                    e.Graphics.DrawFontImage(Symbol, SymbolSize, SymbolColor, new Rectangle(4 + symbolOffset.X, (base.Height - SymbolSize) / 2 + 1 + symbolOffset.Y, SymbolSize, SymbolSize), SymbolOffset.X, SymbolOffset.Y);
                }
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            Cursor = System.Windows.Forms.Cursors.IBeam;
            base.Name = "UITextBox";
            base.Padding = new System.Windows.Forms.Padding(5);
            base.Size = new System.Drawing.Size(250, 29);
            ResumeLayout(false);
        }
    }
}
