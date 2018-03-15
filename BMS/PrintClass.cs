using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Data;
using System.Windows.Forms;

namespace BMS
{
    public class cutePrinter2
    {
        private DataGridView dataGridView1;
        private PrintDocument printDocument;
        private PageSetupDialog pageSetupDialog;
        private PrintPreviewDialog printPreviewDialog;

        private string title = "";

        int currentPageIndex = 0;
        int rowCount = 0;
        int pageCount = 0;

        int titleSize = 20;
        bool isCustomHeader = false;

        Brush alertBrush = new SolidBrush(Color.Red);

        string[] header = null;//����Զ���������ַ����������Ҫб�߷ָ�������\��ʾ�����磺����#���� ����#ΪsplitChar 
        string[] uplineHeader = null;//������������ 
        int[] upLineHeaderIndex = null;//���е�����index,���û�����о���Ϊ-1�� 

        public bool isEveryPagePrintTitle = true;//�Ƿ�ÿһҳ��Ҫ��ӡ���⡣ 
        public int headerHeight = 30;//����߶ȡ� 
        public int topMargin = 30; //���߾� 
        public int cellTopMargin = 3;//��Ԫ�񶥱߾� 
        public int cellLeftMargin = 3;//��Ԫ����߾� 
        public char splitChar = '#';//��headerҪ��б�߱�ʾ��ʱ�� 
        public string falseStr = "��";//�����������DataGridView���� false,����ת�����ַ��� 
        public string trueStr = "��";//�����������DataGridView���� true,����ת�����ַ��� 
        public int pageRowCount = 10;//ÿҳ���� 
        public int rowGap = 20;//�и� 
        public int colGap = 3;//ÿ�м�� 
        public int leftMargin = 10;//��߾� 
        public Font titleFont = new Font("����", 24, FontStyle.Bold);//�������� 
        public Font font = new Font("����", 8);//�������� 
        public Font headerFont = new Font("����", 9, FontStyle.Bold);//�������� 
        public Font footerFont = new Font("Arial", 8);//ҳ����ʾҳ�������� 
        public Font upLineFont = new Font("Arial", 9, FontStyle.Bold);//��header��������ʾ��ʱ��������ʾ�����塣 
        public Font underLineFont = new Font("Arial", 8);//��header��������ʾ��ʱ��������ʾ�����塣 
        public Brush brush = new SolidBrush(Color.Black);//��ˢ 
        public bool isAutoPageRowCount = true;//�Ƿ��Զ����������� 
        public int buttomMargin = 1;//�ױ߾� 
        public bool needPrintPageIndex = true;//�Ƿ��ӡҳ��ҳ�� 
        public bool setTongji = false;       //�����Ƿ���ʾͳ��

        //string sTitle = "";          //��ʾ����
        string sTongJi01 = "";           //ͳ��01
        string sTongJi02 = "";          //ͳ��02
        string sTongJi03 = "";          //ͳ��03
        bool isTongji = false;     //�Ƿ���ʾͳ��   

        string time01;         //����ʱ�����
        string time02;

        Font tongJiFont = new Font("����", 14);     //ͳ��
        Font dateFont = new Font("����", 12, FontStyle.Bold);     //���ڱ���


        /// <summary>
        /// ��ͳ�Ʊ����ӡ
        /// </summary>
        /// <param name="dGView">DataGridView</param>
        /// <param name="title">����</param>
        /// <param name="times01">��ʼʱ��</param>
        /// <param name="times02">��ֹʱ��</param>
        /// <param name="tj01">ͳ��01</param>
        /// <param name="tj02">ͳ��02</param>
        /// <param name="tj03">ͳ��03</param>
        /// <param name="tj">ȷ���Ƿ��ӡͳ��</param>
        /// <param name="iPrintType">��ӡ��ʽѡ��Ĭ��2</param>
        public cutePrinter2(DataGridView dGView, string title, string times01, string times02, string tj01, string tj02, string tj03, bool tj)
        {
            this.title = title;
            this.sTongJi01 = tj01;
            this.sTongJi02 = tj02;
            this.sTongJi03 = tj03;

            this.time01 = times01;
            this.time02 = times02;

            this.setTongji = tj;

            this.dataGridView1 = dGView;
            printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(this.printDocument_PrintPage);

        }


        public bool setTowLineHeader(string[] upLineHeader, int[] upLineHeaderIndex)
        {
            this.uplineHeader = upLineHeader;
            this.upLineHeaderIndex = upLineHeaderIndex;
            this.isCustomHeader = true;
            return true;
        }
        public bool setHeader(string[] header)
        {
            this.header = header;
            return true;

        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            #region ��ӡ --- ͳ�Ʊ���(�걨��)
            int width = e.PageBounds.Width;
            int height = e.PageBounds.Height;
            this.leftMargin = 5;   //����������߾�

            if (this.isAutoPageRowCount)
            {
                pageRowCount = (int)((height - this.topMargin - titleSize - 25 - this.headerFont.Height - this.headerHeight - this.buttomMargin) / this.rowGap);
            }

            pageCount = (int)(rowCount / pageRowCount);
            if (rowCount % pageRowCount > 0)
                pageCount++;

            if (this.setTongji && pageCount == 1)
            {
                pageRowCount = (int)((height - this.topMargin - titleSize - 25 - this.headerFont.Height - this.headerHeight - this.buttomMargin - 25) / this.rowGap);
                pageCount = (int)(rowCount / pageRowCount);
                if (rowCount % pageRowCount > 0)
                    pageCount++;
            }


            //string sDateTitle = time01 + " �� " + time02;

            int xoffset = (int)((width - e.Graphics.MeasureString(this.title, this.titleFont).Width) / 2);
            //int xoffset2 = (int)((width - e.Graphics.MeasureString(sDateTitle, dateFont).Width) / 2);

            int colCount = 0;
            int x = 0;
            int y = topMargin;
            string cellValue = "";

            int startRow = currentPageIndex * pageRowCount;
            int endRow = startRow + this.pageRowCount < rowCount ? startRow + pageRowCount : rowCount;
            int currentPageRowCount = endRow - startRow;



            if (this.currentPageIndex == 0 || this.isEveryPagePrintTitle)
            {

                e.Graphics.DrawString(this.title, titleFont, brush, xoffset, y);
                //e.Graphics.DrawString(sDateTitle, dateFont, brush, xoffset2, y + 40);
                y += titleSize + 20;
            }

            try
            {

                colCount = dataGridView1.ColumnCount;

                y += rowGap;
                x = leftMargin;


                DrawLine(new Point(x, y), new Point(x, y + currentPageRowCount * rowGap + this.headerHeight), e.Graphics);//����ߵ����� 

                int lastIndex = -1;
                int lastLength = 0;
                int indexj = -1;

                for (int j = 0; j < colCount; j++)
                {
                    int colWidth = GetWidth(j);
                    if (colWidth > 0)
                    {
                        indexj++;
                        if (this.header == null || this.header[indexj] == "")
                            cellValue = dataGridView1.Columns[j].HeaderText;
                        else
                            cellValue = header[indexj];

                        if (this.isCustomHeader)
                        {
                            if (this.upLineHeaderIndex[indexj] != lastIndex)
                            {

                                if (lastLength > 0 && lastIndex > -1)//��ʼ����һ��upline 
                                {
                                    string upLineStr = this.uplineHeader[lastIndex];
                                    int upXOffset = (int)((lastLength - e.Graphics.MeasureString(upLineStr, this.upLineFont).Width) / 2);
                                    if (upXOffset < 0)
                                        upXOffset = 0;
                                    e.Graphics.DrawString(upLineStr, this.upLineFont, brush, x - lastLength + upXOffset, y + (int)(this.cellTopMargin / 2));

                                    DrawLine(new Point(x - lastLength, y + (int)(this.headerHeight / 2)), new Point(x, y + (int)(this.headerHeight / 2)), e.Graphics);//���� 
                                    DrawLine(new Point(x, y), new Point(x, y + (int)(this.headerHeight / 2)), e.Graphics);
                                }
                                lastIndex = this.upLineHeaderIndex[indexj];
                                lastLength = colWidth + colGap;
                            }
                            else
                            {
                                lastLength += colWidth + colGap;
                            }
                        }

                        //int currentY=y+cellTopMargin; 


                        int Xoffset = 10;
                        int Yoffset = 20;
                        int leftWordIndex = cellValue.IndexOf(this.splitChar);
                        if (this.upLineHeaderIndex != null && this.upLineHeaderIndex[indexj] > -1)
                        {

                            if (leftWordIndex > 0)
                            {
                                string leftWord = cellValue.Substring(0, leftWordIndex);
                                string rightWord = cellValue.Substring(leftWordIndex + 1, cellValue.Length - leftWordIndex - 1);
                                //������� 
                                Xoffset = (int)(colWidth + colGap - e.Graphics.MeasureString(rightWord, this.upLineFont).Width);
                                Yoffset = (int)(this.headerHeight / 2 - e.Graphics.MeasureString("a", this.underLineFont).Height);


                                Xoffset = 6;
                                Yoffset = 10;
                                e.Graphics.DrawString(rightWord, this.underLineFont, brush, x + Xoffset - 4, y + (int)(this.headerHeight / 2));
                                e.Graphics.DrawString(leftWord, this.underLineFont, brush, x + 2, y + (int)(this.headerHeight / 2) + (int)(this.cellTopMargin / 2) + Yoffset - 2);
                                DrawLine(new Point(x, y + (int)(this.headerHeight / 2)), new Point(x + colWidth + colGap, y + headerHeight), e.Graphics);
                                x += colWidth + colGap;
                                DrawLine(new Point(x, y + (int)(this.headerHeight / 2)), new Point(x, y + currentPageRowCount * rowGap + this.headerHeight), e.Graphics);
                            }
                            else
                            {

                                e.Graphics.DrawString(cellValue, headerFont, brush, x, y + (int)(this.headerHeight / 2) + (int)(this.cellTopMargin / 2));
                                x += colWidth + colGap;
                                DrawLine(new Point(x, y + (int)(this.headerHeight / 2)), new Point(x, y + currentPageRowCount * rowGap + this.headerHeight), e.Graphics);
                            }

                        }
                        else
                        {
                            if (leftWordIndex > 0)
                            {
                                string leftWord = cellValue.Substring(0, leftWordIndex);
                                string rightWord = cellValue.Substring(leftWordIndex + 1, cellValue.Length - leftWordIndex - 1);
                                //������� 
                                Xoffset = (int)(colWidth + colGap - e.Graphics.MeasureString(rightWord, this.upLineFont).Width);
                                Yoffset = (int)(this.headerHeight - e.Graphics.MeasureString("a", this.underLineFont).Height);

                                e.Graphics.DrawString(rightWord, this.headerFont, brush, x + Xoffset - 4, y + 2);
                                e.Graphics.DrawString(leftWord, this.headerFont, brush, x + 2, y + Yoffset - 4);
                                DrawLine(new Point(x, y), new Point(x + colWidth + colGap, y + headerHeight), e.Graphics);
                                x += colWidth + colGap;
                                DrawLine(new Point(x, y), new Point(x, y + currentPageRowCount * rowGap + this.headerHeight), e.Graphics);
                            }
                            else
                            {
                                e.Graphics.DrawString(cellValue, headerFont, brush, x, y + cellTopMargin);
                                x += colWidth + colGap;
                                DrawLine(new Point(x, y), new Point(x, y + currentPageRowCount * rowGap + this.headerHeight), e.Graphics);
                            }

                        }

                    }
                }
                ////ѭ�������������һ����upLine 
                if (this.isCustomHeader)
                {

                    if (lastLength > 0 && lastIndex > -1)//��ʼ����һ��upline 
                    {
                        string upLineStr = this.uplineHeader[lastIndex];
                        int upXOffset = (int)((lastLength - e.Graphics.MeasureString(upLineStr, this.upLineFont).Width) / 2);
                        if (upXOffset < 0)
                            upXOffset = 0;
                        e.Graphics.DrawString(upLineStr, this.upLineFont, brush, x - lastLength + upXOffset, y + (int)(this.cellTopMargin / 2));

                        DrawLine(new Point(x - lastLength, y + (int)(this.headerHeight / 2)), new Point(x, y + (int)(this.headerHeight / 2)), e.Graphics);//���� 
                        DrawLine(new Point(x, y), new Point(x, y + (int)(this.headerHeight / 2)), e.Graphics);
                    }

                }

                int rightBound = x;

                DrawLine(new Point(leftMargin, y), new Point(rightBound, y), e.Graphics); //��������� 

                //DrawLine(new Point(leftMargin,y+this.headerHeight),new Point(rightBound,y+this.headerHeight),e.Graphics);//������������� 

                y += this.headerHeight;


                //print all rows 
                for (int i = startRow; i < endRow; i++)
                {

                    x = leftMargin;
                    for (int j = 0; j < colCount; j++)
                    {
                        if (dataGridView1.Columns[j].Width > 0)
                        {
                            if (dataGridView1.Rows[i].Cells[j].ValueType == typeof(DateTime))
                            {
                                cellValue = Convert.ToDateTime(dataGridView1.Rows[i].Cells[j].Value).ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                cellValue = dataGridView1.Rows[i].Cells[j].Value.ToString();
                            }
                            if (cellValue == "False")
                                cellValue = falseStr;
                            if (cellValue == "True")
                                cellValue = trueStr;

                            e.Graphics.DrawString(cellValue, font, brush, x + this.cellLeftMargin, y + cellTopMargin);

                            int colWidth = GetWidth(j);

                            x += colWidth + colGap;
                            y = y + rowGap * (cellValue.Split(new char[] { '\r', '\n' }).Length - 1);
                        }
                    }
                    DrawLine(new Point(leftMargin, y), new Point(rightBound, y), e.Graphics);
                    y += rowGap;
                }
                DrawLine(new Point(leftMargin, y), new Point(rightBound, y), e.Graphics);

                currentPageIndex++;

                if (this.setTongji && currentPageIndex == pageCount)
                    this.isTongji = true;

                if (this.isTongji)
                {
                    int xoffsetTongJi = (int)((width - e.Graphics.MeasureString(sTongJi01, dateFont).Width) / 2);
                    e.Graphics.DrawString(this.sTongJi01, this.tongJiFont, brush, xoffsetTongJi, y + 25);          //ͳ��01

                    e.Graphics.DrawString(this.sTongJi02, this.tongJiFont, brush, xoffsetTongJi, y + 50);          //ͳ��03
                    e.Graphics.DrawString(this.sTongJi03, this.tongJiFont, brush, xoffsetTongJi + 340, y + 50);       �� //ͳ��04
                }

                if (this.needPrintPageIndex)
                {
                    if (pageCount != 1)
                    {
                        e.Graphics.DrawString("�� " + pageCount.ToString() + " ҳ,��ǰ�� " + this.currentPageIndex.ToString() + " ҳ", this.footerFont, brush, width - 200, (int)(height - this.buttomMargin / 2 - this.footerFont.Height));
                    }
                }

                string s = cellValue;
                string f3 = cellValue;

                if (currentPageIndex < pageCount)
                {
                    e.HasMorePages = true;
                }
                else
                {
                    e.HasMorePages = false;
                    this.currentPageIndex = 0;

                }
                //iPageNumber+=1; 

            }
            catch
            {

            }

            #endregion

        }
        private void DrawLine(Point sp, Point ep, Graphics gp)
        {
            Pen pen = new Pen(Color.Black);
            gp.DrawLine(pen, sp, ep);
        }

        public PrintDocument GetPrintDocument()
        {
            return printDocument;
        }

        private int GetWidth(int value)
        {
            int colWidth = 60;
            switch (value)
            {
                case 0:
                    colWidth = 40;
                    break;
                case 1:
                    colWidth = 70;
                    break;
                case 2:
                    colWidth = 60;
                    break;
                case 3:
                    colWidth = 50;
                    break;
                case 4:
                    colWidth = 80;
                    break;
                case 5:
                    colWidth = 90;
                    break;
                case 6:
                    colWidth = 90;
                    break;
                case 7:
                    colWidth = 75;
                    break;
                case 8:
                    colWidth = 60;
                    break;
                case 9:
                    colWidth = 80;
                    break;
                case 10:
                    colWidth = 70;
                    break;
                case 11:
                    colWidth = 70;
                    break;
                case 12:
                    colWidth = 60;
                    break;
                case 13:
                    colWidth = 50;
                    break;
                case 14:
                    colWidth = 60;
                    break;
                case 15:
                    colWidth = 70;
                    break;
                default:
                    break;
            }
            return colWidth;
        }

        public void Print()
        {
            rowCount = 0;
            try
            {
                if (dataGridView1.DataSource.GetType().ToString() == "System.Data.DataTable")
                {
                    rowCount = ((DataTable)dataGridView1.DataSource).Rows.Count;
                }
                else if (dataGridView1.DataSource.GetType().ToString() == "System.Data.DataView")
                {
                    rowCount = ((DataView)dataGridView1.DataSource).Count;
                }

                pageSetupDialog = new PageSetupDialog();
                pageSetupDialog.AllowOrientation = true;
                pageSetupDialog.Document = printDocument;
                pageSetupDialog.Document.DefaultPageSettings.Landscape = true;        //    ���ô�ӡΪ����
                pageSetupDialog.ShowDialog();

                printPreviewDialog = new PrintPreviewDialog();
                printPreviewDialog.Document = printDocument;
                printPreviewDialog.Height = 600;
                printPreviewDialog.Width = 800;
                printPreviewDialog.ClientSize = new System.Drawing.Size(1024, 768);
                printPreviewDialog.PrintPreviewControl.Zoom = 1;
                printPreviewDialog.ShowDialog();
            }
            catch (Exception e)
            {
                throw new Exception("Printer error." + e.Message);
            }

        }
    }
}
