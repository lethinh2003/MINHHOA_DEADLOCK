namespace OperatingSystem
{
    partial class frmOS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOS));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnRun = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnExit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnInput = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnInput = new System.Windows.Forms.Panel();
            this.txtRequest = new System.Windows.Forms.TextBox();
            this.lblRequest = new System.Windows.Forms.Label();
            this.txtResourceAllocationProcess = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtAvailable = new System.Windows.Forms.TextBox();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.btnCal = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnReset = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtNeed = new System.Windows.Forms.TextBox();
            this.txtAllocation = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.lblNeed = new System.Windows.Forms.Label();
            this.lblAllocation = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.txtResourse = new System.Windows.Forms.TextBox();
            this.txtProcess = new System.Windows.Forms.TextBox();
            this.lblResource = new System.Windows.Forms.Label();
            this.lblProcess = new System.Windows.Forms.Label();
            this.SideBarBottom = new System.Windows.Forms.Timer(this.components);
            this.pnPaint = new System.Windows.Forms.FlowLayoutPanel();
            this.cResource = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnTotal = new System.Windows.Forms.FlowLayoutPanel();
            this.cTotal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbFunction = new System.Windows.Forms.ComboBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.cbRunType = new System.Windows.Forms.ComboBox();
            this.pnInput.SuspendLayout();
            this.pnPaint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cResource)).BeginInit();
            this.pnTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.btnRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            resources.ApplyResources(this.btnRun, "btnRun");
            this.btnRun.BorderRadius = 0;
            this.btnRun.ButtonText = "RUN";
            this.btnRun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRun.DisabledColor = System.Drawing.Color.Gray;
            this.btnRun.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRun.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnRun.Iconimage")));
            this.btnRun.Iconimage_right = null;
            this.btnRun.Iconimage_right_Selected = null;
            this.btnRun.Iconimage_Selected = null;
            this.btnRun.IconMarginLeft = 0;
            this.btnRun.IconMarginRight = 0;
            this.btnRun.IconRightVisible = true;
            this.btnRun.IconRightZoom = 0D;
            this.btnRun.IconVisible = false;
            this.btnRun.IconZoom = 90D;
            this.btnRun.IsTab = false;
            this.btnRun.Name = "btnRun";
            this.btnRun.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnRun.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.btnRun.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRun.selected = false;
            this.btnRun.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRun.Textcolor = System.Drawing.Color.White;
            this.btnRun.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnExit
            // 
            this.btnExit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.BorderRadius = 0;
            this.btnExit.ButtonText = "EXIT";
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DisabledColor = System.Drawing.Color.Gray;
            this.btnExit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnExit.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnExit.Iconimage")));
            this.btnExit.Iconimage_right = null;
            this.btnExit.Iconimage_right_Selected = null;
            this.btnExit.Iconimage_Selected = null;
            this.btnExit.IconMarginLeft = 0;
            this.btnExit.IconMarginRight = 0;
            this.btnExit.IconRightVisible = true;
            this.btnExit.IconRightZoom = 0D;
            this.btnExit.IconVisible = false;
            this.btnExit.IconZoom = 90D;
            this.btnExit.IsTab = false;
            this.btnExit.Name = "btnExit";
            this.btnExit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnExit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.btnExit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnExit.selected = false;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExit.Textcolor = System.Drawing.Color.White;
            this.btnExit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnInput
            // 
            this.btnInput.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.btnInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            resources.ApplyResources(this.btnInput, "btnInput");
            this.btnInput.BorderRadius = 0;
            this.btnInput.ButtonText = "INPUT";
            this.btnInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInput.DisabledColor = System.Drawing.Color.Gray;
            this.btnInput.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInput.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnInput.Iconimage")));
            this.btnInput.Iconimage_right = null;
            this.btnInput.Iconimage_right_Selected = null;
            this.btnInput.Iconimage_Selected = null;
            this.btnInput.IconMarginLeft = 0;
            this.btnInput.IconMarginRight = 0;
            this.btnInput.IconRightVisible = true;
            this.btnInput.IconRightZoom = 0D;
            this.btnInput.IconVisible = false;
            this.btnInput.IconZoom = 90D;
            this.btnInput.IsTab = false;
            this.btnInput.Name = "btnInput";
            this.btnInput.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnInput.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.btnInput.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInput.selected = false;
            this.btnInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInput.Textcolor = System.Drawing.Color.White;
            this.btnInput.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // pnInput
            // 
            this.pnInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.pnInput.Controls.Add(this.txtRequest);
            this.pnInput.Controls.Add(this.lblRequest);
            this.pnInput.Controls.Add(this.txtResourceAllocationProcess);
            this.pnInput.Controls.Add(this.lblTotal);
            this.pnInput.Controls.Add(this.txtTotal);
            this.pnInput.Controls.Add(this.txtAvailable);
            this.pnInput.Controls.Add(this.lblAvailable);
            this.pnInput.Controls.Add(this.btnCal);
            this.pnInput.Controls.Add(this.btnReset);
            this.pnInput.Controls.Add(this.txtNeed);
            this.pnInput.Controls.Add(this.txtAllocation);
            this.pnInput.Controls.Add(this.txtMax);
            this.pnInput.Controls.Add(this.lblNeed);
            this.pnInput.Controls.Add(this.lblAllocation);
            this.pnInput.Controls.Add(this.lblMax);
            this.pnInput.Controls.Add(this.txtResourse);
            this.pnInput.Controls.Add(this.txtProcess);
            this.pnInput.Controls.Add(this.lblResource);
            this.pnInput.Controls.Add(this.lblProcess);
            resources.ApplyResources(this.pnInput, "pnInput");
            this.pnInput.Name = "pnInput";
            // 
            // txtRequest
            // 
            resources.ApplyResources(this.txtRequest, "txtRequest");
            this.txtRequest.Name = "txtRequest";
            // 
            // lblRequest
            // 
            resources.ApplyResources(this.lblRequest, "lblRequest");
            this.lblRequest.ForeColor = System.Drawing.Color.White;
            this.lblRequest.Name = "lblRequest";
            // 
            // txtResourceAllocationProcess
            // 
            resources.ApplyResources(this.txtResourceAllocationProcess, "txtResourceAllocationProcess");
            this.txtResourceAllocationProcess.Name = "txtResourceAllocationProcess";
            this.txtResourceAllocationProcess.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProcessRequest_KeyPress);
            // 
            // lblTotal
            // 
            resources.ApplyResources(this.lblTotal, "lblTotal");
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Name = "lblTotal";
            // 
            // txtTotal
            // 
            resources.ApplyResources(this.txtTotal, "txtTotal");
            this.txtTotal.Name = "txtTotal";
            // 
            // txtAvailable
            // 
            resources.ApplyResources(this.txtAvailable, "txtAvailable");
            this.txtAvailable.Name = "txtAvailable";
            // 
            // lblAvailable
            // 
            resources.ApplyResources(this.lblAvailable, "lblAvailable");
            this.lblAvailable.ForeColor = System.Drawing.Color.White;
            this.lblAvailable.Name = "lblAvailable";
            // 
            // btnCal
            // 
            this.btnCal.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.btnCal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            resources.ApplyResources(this.btnCal, "btnCal");
            this.btnCal.BorderRadius = 0;
            this.btnCal.ButtonText = "CALCULATE";
            this.btnCal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCal.DisabledColor = System.Drawing.Color.Gray;
            this.btnCal.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCal.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCal.Iconimage")));
            this.btnCal.Iconimage_right = null;
            this.btnCal.Iconimage_right_Selected = null;
            this.btnCal.Iconimage_Selected = null;
            this.btnCal.IconMarginLeft = 0;
            this.btnCal.IconMarginRight = 0;
            this.btnCal.IconRightVisible = true;
            this.btnCal.IconRightZoom = 0D;
            this.btnCal.IconVisible = false;
            this.btnCal.IconZoom = 90D;
            this.btnCal.IsTab = false;
            this.btnCal.Name = "btnCal";
            this.btnCal.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.btnCal.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.btnCal.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCal.selected = false;
            this.btnCal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCal.Textcolor = System.Drawing.Color.White;
            this.btnCal.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btnReset
            // 
            this.btnReset.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            resources.ApplyResources(this.btnReset, "btnReset");
            this.btnReset.BorderRadius = 0;
            this.btnReset.ButtonText = "RESET";
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.DisabledColor = System.Drawing.Color.Gray;
            this.btnReset.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReset.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnReset.Iconimage")));
            this.btnReset.Iconimage_right = null;
            this.btnReset.Iconimage_right_Selected = null;
            this.btnReset.Iconimage_Selected = null;
            this.btnReset.IconMarginLeft = 0;
            this.btnReset.IconMarginRight = 0;
            this.btnReset.IconRightVisible = true;
            this.btnReset.IconRightZoom = 0D;
            this.btnReset.IconVisible = false;
            this.btnReset.IconZoom = 90D;
            this.btnReset.IsTab = false;
            this.btnReset.Name = "btnReset";
            this.btnReset.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.btnReset.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.btnReset.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReset.selected = false;
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReset.Textcolor = System.Drawing.Color.White;
            this.btnReset.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtNeed
            // 
            resources.ApplyResources(this.txtNeed, "txtNeed");
            this.txtNeed.Name = "txtNeed";
            this.txtNeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNeed_KeyPress);
            // 
            // txtAllocation
            // 
            resources.ApplyResources(this.txtAllocation, "txtAllocation");
            this.txtAllocation.Name = "txtAllocation";
            this.txtAllocation.DoubleClick += new System.EventHandler(this.txtAllocation_DoubleClick);
            // 
            // txtMax
            // 
            resources.ApplyResources(this.txtMax, "txtMax");
            this.txtMax.Name = "txtMax";
            // 
            // lblNeed
            // 
            resources.ApplyResources(this.lblNeed, "lblNeed");
            this.lblNeed.ForeColor = System.Drawing.Color.White;
            this.lblNeed.Name = "lblNeed";
            // 
            // lblAllocation
            // 
            resources.ApplyResources(this.lblAllocation, "lblAllocation");
            this.lblAllocation.ForeColor = System.Drawing.Color.White;
            this.lblAllocation.Name = "lblAllocation";
            // 
            // lblMax
            // 
            resources.ApplyResources(this.lblMax, "lblMax");
            this.lblMax.ForeColor = System.Drawing.Color.White;
            this.lblMax.Name = "lblMax";
            // 
            // txtResourse
            // 
            resources.ApplyResources(this.txtResourse, "txtResourse");
            this.txtResourse.Name = "txtResourse";
            this.txtResourse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtResourse_KeyPress);
            // 
            // txtProcess
            // 
            resources.ApplyResources(this.txtProcess, "txtProcess");
            this.txtProcess.Name = "txtProcess";
            this.txtProcess.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProcess_KeyPress);
            // 
            // lblResource
            // 
            resources.ApplyResources(this.lblResource, "lblResource");
            this.lblResource.ForeColor = System.Drawing.Color.White;
            this.lblResource.Name = "lblResource";
            // 
            // lblProcess
            // 
            resources.ApplyResources(this.lblProcess, "lblProcess");
            this.lblProcess.ForeColor = System.Drawing.Color.White;
            this.lblProcess.Name = "lblProcess";
            // 
            // SideBarBottom
            // 
            this.SideBarBottom.Interval = 10;
            this.SideBarBottom.Tick += new System.EventHandler(this.SideBarBottom_Tick);
            // 
            // pnPaint
            // 
            resources.ApplyResources(this.pnPaint, "pnPaint");
            this.pnPaint.BackColor = System.Drawing.Color.White;
            this.pnPaint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnPaint.Controls.Add(this.cResource);
            this.pnPaint.Name = "pnPaint";
            // 
            // cResource
            // 
            chartArea1.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisX.ScrollBar.ButtonStyle = System.Windows.Forms.DataVisualization.Charting.ScrollBarButtonStyles.None;
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.Name = "ChartArea1";
            this.cResource.ChartAreas.Add(chartArea1);
            resources.ApplyResources(this.cResource, "cResource");
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.cResource.Legends.Add(legend1);
            this.cResource.Name = "cResource";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.cResource.Series.Add(series1);
            this.cResource.Customize += new System.EventHandler(this.cResource_Customize);
            // 
            // pnTotal
            // 
            resources.ApplyResources(this.pnTotal, "pnTotal");
            this.pnTotal.BackColor = System.Drawing.Color.White;
            this.pnTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnTotal.Controls.Add(this.cTotal);
            this.pnTotal.Name = "pnTotal";
            // 
            // cTotal
            // 
            chartArea2.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea2.AxisX.IsMarginVisible = false;
            chartArea2.AxisX.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.MajorTickMark.Enabled = false;
            chartArea2.AxisX.ScrollBar.ButtonStyle = System.Windows.Forms.DataVisualization.Charting.ScrollBarButtonStyles.None;
            chartArea2.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisY.IsReversed = true;
            chartArea2.Name = "ChartArea1";
            this.cTotal.ChartAreas.Add(chartArea2);
            resources.ApplyResources(this.cTotal, "cTotal");
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.cTotal.Legends.Add(legend2);
            this.cTotal.Name = "cTotal";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.cTotal.Series.Add(series2);
            this.cTotal.Customize += new System.EventHandler(this.cTotal_Customize);
            // 
            // cbFunction
            // 
            resources.ApplyResources(this.cbFunction, "cbFunction");
            this.cbFunction.FormattingEnabled = true;
            this.cbFunction.Name = "cbFunction";
            this.cbFunction.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbFunction_KeyPress);
            // 
            // lblResult
            // 
            resources.ApplyResources(this.lblResult, "lblResult");
            this.lblResult.Name = "lblResult";
            // 
            // txtResult
            // 
            resources.ApplyResources(this.txtResult, "txtResult");
            this.txtResult.Name = "txtResult";
            this.txtResult.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtResult_KeyPress);
            // 
            // cbRunType
            // 
            resources.ApplyResources(this.cbRunType, "cbRunType");
            this.cbRunType.FormattingEnabled = true;
            this.cbRunType.Name = "cbRunType";
            this.cbRunType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbRunType_KeyPress);
            // 
            // frmOS
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbRunType);
            this.Controls.Add(this.pnInput);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.cbFunction);
            this.Controls.Add(this.pnTotal);
            this.Controls.Add(this.pnPaint);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOS";
            this.Load += new System.EventHandler(this.frmOS_Load);
            this.pnInput.ResumeLayout(false);
            this.pnInput.PerformLayout();
            this.pnPaint.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cResource)).EndInit();
            this.pnTotal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cTotal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnRun;
        private Bunifu.Framework.UI.BunifuFlatButton btnExit;
        private Bunifu.Framework.UI.BunifuFlatButton btnInput;
        private System.Windows.Forms.Panel pnInput;
        private System.Windows.Forms.Label lblProcess;
        private System.Windows.Forms.TextBox txtProcess;
        private System.Windows.Forms.Label lblResource;
        private System.Windows.Forms.Label lblNeed;
        private System.Windows.Forms.Label lblAllocation;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.TextBox txtResourse;
        private System.Windows.Forms.TextBox txtNeed;
        private System.Windows.Forms.TextBox txtAllocation;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Timer SideBarBottom;
        private Bunifu.Framework.UI.BunifuFlatButton btnReset;
        private Bunifu.Framework.UI.BunifuFlatButton btnCal;
        private System.Windows.Forms.TextBox txtAvailable;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.FlowLayoutPanel pnPaint;
        private System.Windows.Forms.FlowLayoutPanel pnTotal;
        private System.Windows.Forms.ComboBox cbFunction;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.ComboBox cbRunType;
        private System.Windows.Forms.Label lblRequest;
        private System.Windows.Forms.TextBox txtResourceAllocationProcess;
        private System.Windows.Forms.TextBox txtRequest;
        private System.Windows.Forms.DataVisualization.Charting.Chart cResource;
        private System.Windows.Forms.DataVisualization.Charting.Chart cTotal;
    }
}

