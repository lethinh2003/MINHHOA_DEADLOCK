using ShowMessage;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace OperatingSystem
{
    public partial class frmOS : Form
    {
        public frmOS()
        {
            InitializeComponent();
        }


        Random rd = new Random();
        List<Color> colors = new List<Color>();
        bool sliderbarExpand;
        int Col, Row, p;
        int[] Total, TotalCol, Request;
        int[,] Max, Allocation, Need,Available, allocationCoppy;
        string[] Function = {"Safe Squence", "Resource Allocation"};
        string[] RunType = { "Step by step", "Sync" };
        string tmp;

        private void UpdateMatrix(int[,] a)
        {
            txtAllocation.Text = "";
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Col; j++)
                {
                    txtAllocation.Text += a[i, j].ToString() + ' ';
                }
                txtAllocation.Text += "\r\n";
            }



        }
        private void Cal()
        {
            if(txtProcess.Text == "" || txtResourse.Text == "" || txtTotal.Text == "" || txtMax.Text == "" || txtAllocation.Text == "")
            {
                ShowMessage.ShowMessage.MsgShow("Please make sure you have filled it out completely", MsgType.Exclamation, MsgButton.OkOnly, MsgLanguage.English);
            }
            else
            {
                Row = Convert.ToInt16(txtProcess.Text);
                Col = Convert.ToInt16(txtResourse.Text);
                Total = new int[Col + 1];
                TotalCol = new int[Col + 1];
                Max = new int[Row + 1, Col + 1];
                Allocation = new int[Row + 1, Col + 1];
                allocationCoppy = new int[Row + 1, Col + 1];
                Need = new int[Row + 1, Col + 1];
                Available = new int[Row + 2, Col + 1];
                txtAvailable.Clear();
                txtNeed.Clear();
                tmp = null;
                // gán ma trận 1 chiều trong txtTotal
                string[] arrayTotal = txtTotal.Text.Split(' ');
                // gán ma trận trong textbox thành kiểu chuỗi string[,]
                var arrayMax = txtMax.Text.Split('\n').Select(line => line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)).ToArray();
                var arrayAllocation = txtAllocation.Text.Split('\n').Select(line => line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)).ToArray();


                // chuyển sang kiểu int
                for (int i = 0; i < Col; i++)
                    Total[i] = Int32.Parse(arrayTotal[i]);

                for (int i = 0; i < Row; i++)
                {
                    for (int j = 0; j < Col; j++)
                    {
                        if (int.TryParse(arrayMax[i][j], out int value))
                        {
                            Max[i, j] = value;
                        }
                    }
                }

                for (int i = 0; i < Row; i++)
                {
                    for (int j = 0; j < Col; j++)
                    {
                        if (int.TryParse(arrayAllocation[i][j], out int value))
                        {
                           Allocation[i, j] = value;
                        }
                    }
                }

                // Coppy lại Allocation
                for (int i = 0; i < Row; i++)
                {
                    for (int j = 0; j < Col; j++)
                    {
                        allocationCoppy[i, j] = Allocation[i, j];
                    }
                }

                txtAllocation.Text = "";
                for(int i = 0; i < Row; i++)
                {
                   for (int j = 0; j < Col; j++)
                   {
                       txtAllocation.Text += Allocation[i, j].ToString() + ' ';
                   }
                   txtAllocation.Text += "\r\n";
                }

                //tính need với need = max - allocation
                for (int i = 0; i < Row; i++)
                {
                    for (int j = 0; j < Col; j++)
                    {
                        Need[i, j] = Max[i, j] - Allocation[i, j];
                    }
                }

                //tính tổng cột allocation
                for (int i = 0; i < Row; i++)
                {
                    for (int j = 0; j <= Col; j++)
                    {
                        TotalCol[j] += Allocation[i, j];
                    }
                }

                //tính available đầu tiên
                for (int i = 0; i < Col; i++)
                {
                    Available[0, i] = Total[i] - TotalCol[i];
                }
                // in ma trận vào textbox
                for (int i = 0; i < Row; i++)
                {
                    for (int j = 0; j < Col; j++)
                    {
                        txtNeed.Text += Need[i, j].ToString() + ' ';
                    }
                    txtNeed.Text += "\r\n";
                }

                for (int i = 0; i < Col; i++)
                    txtAvailable.Text += Available[0, i].ToString() + ' ';
                txtAvailable.Text += "\r\n";
                tmp = txtAvailable.Text;
            }    
            
        }
        private bool isSafe(bool CheckUpdate)
        {
            //Lưu trạng thái các tiến trình kết thúc
            bool[] Finish = new bool[Row];
            //Lưu chuỗi cấp phát an toàn
            int[] safeSequence = new int[Row];
            //Tạo bản sao từ available
            int[] availableCoppy = new int[Col];
            int[,] allocationCoppy = new int[Row, Col];
            int[] deadLock = new int[Row];
            for (int i = 0; i < Col; i++)
                availableCoppy[i] = Available[0, i];

            for (int i = 0; i < Row; i++)
                for (int j = 0; j < Col; j++)
                    allocationCoppy[i, j] = Allocation[i, j];


            int count = 0;
            int counDeadlock = 0;
            if(CheckUpdate == false)
            {

                while(count < Row)
                {
                    bool Found = false;
                    //Tìm tiến trình chưa kết thúc và cập nhật
                    for(int i = 0; i < Row; i++)
                    {
                        //Kiểm tra tiến trình chưa kết thúc
                        if (Finish[i] == false)
                        {
                            //Kiểm tra tất cả các tài nguyên j đều cấp phát được
                            int j;
                            for (j = 0; j < Col; j++)
                                if (Need[i, j] > availableCoppy[j])
                                {
                                    deadLock[counDeadlock++] = i;
                                    break;
                                }    

                            if (j == Col)
                            {
                                //Giả sử cập phát hết và thu hồi tài nguyên
                                for(int k = 0; k < Col; k++)
                                {
                                    availableCoppy[k] += Allocation[i, k];
                                    Available[count + 1, k] = availableCoppy[k];
                                    txtAvailable.Text += Available[count + 1, k].ToString() + ' ';
                                    allocationCoppy[i, k] = 0;
                                
                                }
                                createChartBar(count + 1);
                                UpdateMatrix(allocationCoppy);
                                createChartColumn(allocationCoppy);
                            

                                //Thêm tiến trình vào chuỗi cấp phát an toàn
                                safeSequence[count++] = i;
                                Finish[i] = true;
                                Found = true;
                                if (count - 1 == 0 && Found == true)
                                    if(cbFunction.SelectedIndex == 0)
                                        txtResult.Text = "Secure System" + "\r\n" + "Resource Allocation Order:" + "\r\n";
                                    else if(cbFunction.SelectedIndex == 1)
                                        txtResult.Text += "Secure System" + "\r\n" + "Resource Allocation Order:" + "\r\n";

                                txtResult.Text += "P" + safeSequence[count - 1].ToString() + " ";    
                                txtAvailable.Text += "\r\n";
                                if (cbRunType.SelectedIndex == 0)
                                {
                                    Thread.Sleep(1 * 1000);
                                    Application.DoEvents();
                                }
                                break;
                            }
                        }

                    
                    }
                

                    //Trường hợp tìm không được tiến trình để cập phát
                    if(Found == false)
                    {
                        txtResult.Text = "Insecure System";
                        txtResult.Text += "\r\nDeadlock process are ";
                        for(int i = 0; i < counDeadlock; i++)
                        {
                            txtResult.Text += "P" + deadLock[i].ToString() + ' ';
                        }
                        return false;
                    }

                
                }
            }   
            else
            {
                while (count < Row)
                {
                    bool Found = false;
                    //Tìm tiến trình chưa kết thúc và cập nhật
                    for (int i = 0; i < Row; i++)
                    {
                        //Kiểm tra tiến trình chưa kết thúc
                        if (Finish[i] == false)
                        {
                            //Kiểm tra tất cả các tài nguyên j đều cấp phát được
                            int j;
                            for (j = 0; j < Col; j++)
                                if (Need[i, j] > availableCoppy[j])
                                {
                                    break;
                                }

                            if (j == Col)
                            {
                                //Giả sử cập phát hết và thu hồi tài nguyên
                                for (int k = 0; k < Col; k++)
                                {
                                    availableCoppy[k] += Allocation[i, k];
                                }
                                //Thêm tiến trình vào chuỗi cấp phát an toàn
                                safeSequence[count++] = i;
                                Finish[i] = true;
                                Found = true;
                                break;
                            }
                        }


                    }


                    //Trường hợp tìm không được tiến trình để cập phát
                    if (Found == false)
                    {
                        return false;
                    }

                }
            }    
            return true;
        }

        private bool Banker()
        {
  

            ///

            if (txtNeed.Text == "")
                Cal();
            p = Int32.Parse(txtResourceAllocationProcess.Text);
            Request = new int[Col + 1];
            string[] arrayRequest = txtRequest.Text.Split(' ');

            for (int i = 0; i < Col; i++)
                Request[i] = Int32.Parse(arrayRequest[i]);

            //Tạo bản sao need, available, allocation
            int[,] needCoppy = new int[Row + 1, Col + 1];
            int[,] allocationCoppy = new int[Row + 1, Col + 1];
            int[] availableCoppy = new int[Row + 2];

            for (int i = 0; i < Row; i++)
                for (int j = 0; j < Col; j++)
                {
                    needCoppy[i, j] = Need[i, j];
                    allocationCoppy[i, j] = Allocation[i, j];
                }

            for (int i = 0; i < Col; i++)
                availableCoppy[i] = Available[0, i];


            //Giả sử cấp phát
            for(int r = 0; r < Col; r++)
            {
                //Kiểm tra yêu cầu hợp lệ và cập nhật được
                if (Need[p,r] >= Request[r] && Available[0,r] >= Request[r])
                {
                    //Gả sử cấp phát
                    Need[p, r] -= Request[r];
                    Allocation[p,r] += Request[r];
                    Available[0,r] -= Request[r];
                }
                else
                {
                    txtResult.Text = "Invalid Request";
                    return false;
                }
            }
            //bool flag = isSafe(true);
            UpdateMatrix(Allocation);
            createColor();
            createChartColumn(Allocation);
            Cal();
            createChartBar(0);
            txtResult.Text = "";
            bool flag  = isSafe(false);

            //In kết quả
            txtResult.Text += "\r\nAllocation request from P" + p.ToString() + " with resources:" + "\r\n";
            for (int i = 0; i < Col; i++)
                txtResult.Text += Request[i].ToString() + ' ';
            if (flag)
            {
                txtResult.Text += "has been successfully granted" + "\r\n";
               
            }
            else
                txtResult.Text += "has been unsuccessful\r\n";



            return flag;

        }

        private void createColor()
        {
            int Count = 0;
            while(Count < Col)
            {
                Color color = Color.FromArgb(rd.Next(255), rd.Next(255), rd.Next(255));
                if(!colors.Contains(color))
                {
                    colors.Add(color);
                    Count++;
                }
            }
        }
        private void createChartBar(int n)
        {
            cTotal.Series.Clear();
            // Thêm series -> Tài nguyên
            for (int i = 0; i < Col; i++)
            {
                cTotal.Series.Add("R" + i.ToString());
                cTotal.Series[i].IsValueShownAsLabel = true;
                cTotal.Series[i].IsVisibleInLegend = false;
                cTotal.Series[i].ChartType = SeriesChartType.Bar;
            }

            //Thêm dữ liệu Total
            string strTotal = "Work[";
            for (int i = 0; i < Col; i++)
            {
                if (i != Col - 1)
                    strTotal += Available[n, i].ToString() + ' ';
                else
                    strTotal += Available[n, i].ToString() + ']';
            }

            for (int j = 0; j < Col; j++)
            {
                cTotal.Series[j].Color = colors[j];
                cTotal.Series[j].Points.AddXY(strTotal, Available[n, j].ToString());

            }
        }
        private void createChartColumn(int[,] a)
        {
            cResource.Series.Clear();
            
            // Thêm series -> Tài nguyên
            for (int i = 0; i < Col; i++)
            {            
                cResource.Series.Add("R" + i.ToString());
                cResource.Series[i].IsValueShownAsLabel = true;
                cResource.Series[i].IsVisibleInLegend = false;
                cResource.Series[i].ChartType = SeriesChartType.StackedColumn;
            }



            //Thêm dữ liệu Resouce
            for (int i = 0; i < Row; i++)
            {
                string str = 'P' + i.ToString() + "\r\nA[";
                for(int j = 0; j <  Col; j++)
                {
                    if (j != Col - 1)
                        str += a[i, j].ToString() + ' ';
                    else
                        str += a[i, j].ToString() + "]\r\nN[";
                }

                for (int j = 0; j < Col; j++)
                {
                    if (j != Col - 1)
                        str += Need[i, j].ToString() + ' ';
                    else
                        str += Need[i, j].ToString() + ']';
                }


                for (int j = 0; j < Col; j++)
                {
                    cResource.Series[j].Color = colors[j];
                    cResource.Series[j].Points.AddXY(str, a[i, j].ToString());

                }
            }

        }

        private void frmOS_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < Function.Length; i++)
            {
                cbFunction.Items.Add(Function[i]);
            }

            for (int i = 0; i < RunType.Length; i++)
            {
                cbRunType.Items.Add(RunType[i]);
            }
        }
        private void SideBarBottom_Tick(object sender, EventArgs e)
        {
            if (sliderbarExpand)
            {
                pnInput.Height -= 10;
                if (pnInput.Height == pnInput.MinimumSize.Height)
                {
                    sliderbarExpand = false;
                    SideBarBottom.Stop();
                }
            }
            else
            {
                pnInput.Height += 10;
                if (pnInput.Height == pnInput.MaximumSize.Height)
                {
                    sliderbarExpand = true;
                    SideBarBottom.Stop();
                }
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (cbFunction.Text != "" && cbRunType.Text != "")
            {
                if (cbFunction.SelectedIndex == 0)
                {
                    txtResult.Clear();
                    txtAvailable.Clear();
                    txtAvailable.Text = tmp;
                    isSafe(false);
                }
                else if (cbFunction.SelectedIndex == 1)
                {
                    if (txtRequest.Text == "" || txtResourceAllocationProcess.Text == "")
                    {
                        ShowMessage.ShowMessage.MsgShow("Please make sure you have filled it out completely", MsgType.Exclamation, MsgButton.OkOnly, MsgLanguage.English);
                    }
                    else
                    {
                        txtAvailable.Clear();
                        txtAvailable.Text = tmp;
                        Banker();   
                    }
                }
            }
            else
            {
                ShowMessage.ShowMessage.MsgShow("You have not selected the function yet", MsgType.Exclamation, MsgButton.OkOnly, MsgLanguage.English);
            }    

        }
       
        private void btnInput_Click(object sender, EventArgs e)
        {
            SideBarBottom.Start();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
           
            if(txtProcess.Text != "" && txtResourse.Text != "")
            {
                Cal();
                createColor();
                createChartBar(0);
                createChartColumn(allocationCoppy);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (ShowMessage.ShowMessage.MsgShow("Do you want to quit?", MsgType.Question, MsgButton.YesNo, MsgLanguage.English) == DialogResult.Yes)
                    Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtProcess.Clear();
            txtResourse.Clear();
            txtMax.Clear();
            txtAllocation.Clear();
            txtNeed.Clear();
            txtResult.Clear();
            txtTotal.Clear();
            txtAvailable.Clear();
            txtRequest.Clear();
            txtResourceAllocationProcess.Clear();
            cResource.Series.Clear();
            cTotal.Series.Clear();
            cbFunction.SelectedItem = null;
            cbRunType.SelectedItem = null;
        }

        private void cResource_Customize(object sender, EventArgs e)
        {
            foreach (System.Windows.Forms.DataVisualization.Charting.Series series in cResource.Series)
            {
                foreach (System.Windows.Forms.DataVisualization.Charting.DataPoint point in series.Points)
                {
                    if (point.YValues.Length > 0 && (double)point.YValues.GetValue(0) == 0)
                    {
                        point.IsValueShownAsLabel = false;
                    }
                    else
                    {
                        point.IsValueShownAsLabel = true;
                    }
                }
            }
        }

        private void cTotal_Customize(object sender, EventArgs e)
        {
            foreach (System.Windows.Forms.DataVisualization.Charting.Series series in cTotal.Series)
            {
                foreach (System.Windows.Forms.DataVisualization.Charting.DataPoint point in series.Points)
                {
                    if (point.YValues.Length > 0 && (double)point.YValues.GetValue(0) == 0)
                    {
                        point.IsValueShownAsLabel = false;
                    }
                    else
                    {
                        point.IsValueShownAsLabel = true;
                    }
                }
            }
        }

        private void txtAllocation_DoubleClick(object sender, EventArgs e)
        {
            txtAllocation.Text = "";
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Col; j++)
                {
                    txtAllocation.Text += allocationCoppy[i, j].ToString() + ' ';
                }
                txtAllocation.Text += "\r\n";
            }
            txtAvailable.Clear();
            createChartBar(0);
            createChartColumn(allocationCoppy);
        }

        private void txtProcessRequest_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtProcess_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtResourse_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtNeed_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void txtResult_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbFunction_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbRunType_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
