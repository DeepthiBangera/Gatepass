using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text.RegularExpressions;
using System.Drawing;


namespace Gatepass
{
    public partial class _Default : System.Web.UI.Page
    {
        //List<GatepassDetails> _lstGatepassDetails = new List<GatepassDetails>();

        //public List<int> CurrentList
        //{
        //    get
        //    {
        //        return (List<int>)Session["CurrentList"] ?? new List<int>();
        //    }
        //    set
        //    {
        //        Session["CurrentList"] = value;
        //    }
        //}

        List<GatepassDetails> _lstb1Copies;
     
        private List<GatepassDetails> _lstGatepassDetails = new List<GatepassDetails>();

        public List<GatepassDetails> LstGatepassDetails
        {
            get { return _lstGatepassDetails;}
            set{
                _lstGatepassDetails =value;
                Session["test_list"] = _lstGatepassDetails;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                BindGridData();
                AddDataListToDropDown();
                //Table1.Visible = false;
                //drpJOBnumbers.Visible = false;
                // txtB1.Visible = false;
                // lblB1.Visible = false;
                btnPrint.Enabled = false;
                txtFromDate.Text = DateTime.Now.Date.ToString("dd/MMM/yyyy");
                txtToDate.Text = DateTime.Now.Date.ToString("dd/MMM/yyyy");
                ViewState["MainList"] = LstGatepassDetails;
            }
            if(ViewState["MainList"] != null)
            {

                LstGatepassDetails = (List<GatepassDetails>)ViewState["MainList"];
            }
        }

        public List<GatepassDetails> AddData()
        {
            LstGatepassDetails = new List<GatepassDetails>();
            GatepassDetails objGatepassDetails = new GatepassDetails { IsPrint=true,Date = DateTime.Now.Date.ToString("dd-MMM-yyyy"), JobNumber = "TEST01", PONumber = "1234", CustomerName = "test", CustomerAddress = "Bangalore-19", Design = "TEST_Design", Item = "Test-Item", A1 = "1", B1 = "1", Quantity = "2323", Printer = "Test-Priter", Part = "Test-Part", SalOrdNo = "No Data", ItemCode = "No Data" };
            GatepassDetails objGatepassDetails1 = new GatepassDetails { Date = DateTime.Now.Date.ToString("dd-MMM-yyyy"), JobNumber = "TEST02", PONumber = "1234", CustomerName = "test", CustomerAddress = "Bangalore-19", Design = "TEST_Design", Item = "Test-Item", A1 = "1", B1 = "1", Quantity = "2323", Printer = "Test-Priter", Part = "Test-Part", SalOrdNo = "No Data", ItemCode = "No Data" };
            GatepassDetails objGatepassDetails2 = new GatepassDetails { IsPrint = true, Date = DateTime.Now.Date.ToString("dd-MMM-yyyy"), JobNumber = "TEST03", PONumber = "1234", CustomerName = "test", CustomerAddress = "Bangalore-19", Design = "TEST_Design", Item = "Test-Item", A1 = "1", B1 = "1", Quantity = "2323", Printer = "Test-Priter", Part = "Test-Part", SalOrdNo = "No Data", ItemCode = "No Data" };
            GatepassDetails objGatepassDetails3 = new GatepassDetails { Date = DateTime.Now.Date.ToString("dd-MMM-yyyy"), JobNumber = "TEST04", PONumber = "1234", CustomerName = "test", CustomerAddress = "Bangalore-19", Design = "TEST_Design", Item = "Test-Item", A1 = "1", B1 = "1", Quantity = "2323", Printer = "Test-Priter", Part = "Test-Part", SalOrdNo = "No Data", ItemCode = "No Data" };
            GatepassDetails objGatepassDetails4 = new GatepassDetails {  IsPrint=true,Date = DateTime.Now.Date.ToString("dd-MMM-yyyy"), JobNumber = "TEST05", PONumber = "1234", CustomerName = "test", CustomerAddress = "Bangalore-19", Design = "TEST_Design", Item = "Test-Item", A1 = "1", B1 = "1", Quantity = "2323", Printer = "Test-Priter", Part = "Test-Part", SalOrdNo = "No Data", ItemCode = "No Data" };
            GatepassDetails objGatepassDetails5 = new GatepassDetails { Date = DateTime.Now.Date.ToString("dd-MMM-yyyy"), JobNumber = "TEST06", PONumber = "1234", CustomerName = "test", CustomerAddress = "Bangalore-19", Design = "TEST_Design", Item = "Test-Item", A1 = "1", B1 = "1", Quantity = "2323", Printer = "Test-Priter", Part = "Test-Part", SalOrdNo = "No Data", ItemCode = "No Data" };
            GatepassDetails objGatepassDetails6 = new GatepassDetails { IsPrint = true, Date = DateTime.Now.Date.ToString("dd-MMM-yyyy"), JobNumber = "TEST07", PONumber = "1234", CustomerName = "test", CustomerAddress = "Bangalore-19", Design = "TEST_Design", Item = "Test-Item", A1 = "1", B1 = "1", Quantity = "2323", Printer = "Test-Priter", Part = "Test-Part", SalOrdNo = "No Data", ItemCode = "No Data" };
            GatepassDetails objGatepassDetails7 = new GatepassDetails { Date = DateTime.Now.Date.ToString("dd-MMM-yyyy"), JobNumber = "TEST08", PONumber = "1234", CustomerName = "test", CustomerAddress = "Bangalore-19", Design = "TEST_Design", Item = "Test-Item", A1 = "1", B1 = "1", Quantity = "2323", Printer = "Test-Priter", Part = "Test-Part", SalOrdNo = "No Data", ItemCode = "No Data" };
            GatepassDetails objGatepassDetails8 = new GatepassDetails { Date = DateTime.Now.Date.ToString("dd-MMM-yyyy"), JobNumber = "TEST09", PONumber = "1234", CustomerName = "test", CustomerAddress = "Bangalore-19", Design = "TEST_Design", Item = "Test-Item", A1 = "1", B1 = "1", Quantity = "2323", Printer = "Test-Priter", Part = "Test-Part", SalOrdNo = "No Data", ItemCode = "No Data" };
            GatepassDetails objGatepassDetails9 = new GatepassDetails { Date = DateTime.Now.Date.ToString("dd-MMM-yyyy"), JobNumber = "TEST10", PONumber = "1234", CustomerName = "test", CustomerAddress = "Bangalore-19", Design = "TEST_Design", Item = "Test-Item", A1 = "1", B1 = "1", Quantity = "2323", Printer = "Test-Priter", Part = "Test-Part", SalOrdNo = "No Data", ItemCode = "No Data" };
            GatepassDetails objGatepassDetails10 = new GatepassDetails { Date = DateTime.Now.Date.ToString("dd-MMM-yyyy"), JobNumber = "TEST11", PONumber = "1234", CustomerName = "test", CustomerAddress = "Bangalore-19", Design = "TEST_Design", Item = "Test-Item", A1 = "1", B1 = "1", Quantity = "2323", Printer = "Test-Priter", Part = "Test-Part", SalOrdNo = "No Data", ItemCode = "No Data" };
            GatepassDetails objGatepassDetails11 = new GatepassDetails { Date = DateTime.Now.Date.ToString("dd-MMM-yyyy"), JobNumber = "TEST12", PONumber = "1234", CustomerName = "test", CustomerAddress = "Bangalore-19", Design = "TEST_Design", Item = "Test-Item", A1 = "1", B1 = "1", Quantity = "2323", Printer = "Test-Priter", Part = "Test-Part", SalOrdNo = "No Data", ItemCode = "No Data" };
            GatepassDetails objGatepassDetails12 = new GatepassDetails { Date = DateTime.Now.Date.ToString("dd-MMM-yyyy"), JobNumber = "TEST13", PONumber = "1234", CustomerName = "test", CustomerAddress = "Bangalore-19", Design = "TEST_Design", Item = "Test-Item", A1 = "1", B1 = "1", Quantity = "2323", Printer = "Test-Priter", Part = "Test-Part", SalOrdNo = "No Data", ItemCode = "No Data" };
            GatepassDetails objGatepassDetails13 = new GatepassDetails { Date = DateTime.Now.Date.ToString("dd-MMM-yyyy"), JobNumber = "TEST14", PONumber = "1234", CustomerName = "test", CustomerAddress = "Bangalore-19", Design = "TEST_Design", Item = "Test-Item", A1 = "1", B1 = "1", Quantity = "2323", Printer = "Test-Priter", Part = "Test-Part", SalOrdNo = "No Data", ItemCode = "No Data" };
            GatepassDetails objGatepassDetails14 = new GatepassDetails { Date = DateTime.Now.Date.ToString("dd-MMM-yyyy"), JobNumber = "TEST15", PONumber = "1234", CustomerName = "test", CustomerAddress = "Bangalore-19", Design = "TEST_Design", Item = "Test-Item", A1 = "1", B1 = "1", Quantity = "2323", Printer = "Test-Priter", Part = "Test-Part", SalOrdNo = "No Data", ItemCode = "No Data" };
            _lstGatepassDetails.Add(objGatepassDetails);
            _lstGatepassDetails.Add(objGatepassDetails1);
            _lstGatepassDetails.Add(objGatepassDetails2);
            _lstGatepassDetails.Add(objGatepassDetails3);
            _lstGatepassDetails.Add(objGatepassDetails4);
            _lstGatepassDetails.Add(objGatepassDetails5);
            _lstGatepassDetails.Add(objGatepassDetails6);
            _lstGatepassDetails.Add(objGatepassDetails7);
            _lstGatepassDetails.Add(objGatepassDetails8);
            _lstGatepassDetails.Add(objGatepassDetails9);
            _lstGatepassDetails.Add(objGatepassDetails10);
            _lstGatepassDetails.Add(objGatepassDetails11);
            _lstGatepassDetails.Add(objGatepassDetails12);
            _lstGatepassDetails.Add(objGatepassDetails13);
            _lstGatepassDetails.Add(objGatepassDetails14);

            //if (_lstb1Copies != null)
            //{
            //    if (_lstb1Copies.Count != 0)
            //    {
            //        _lstGatepassDetails.AddRange(_lstb1Copies);
            //    }
            //}

            return LstGatepassDetails;
        }

        public void BindGridData()
        {
            grdTable.DataSource = AddData();
            grdTable.DataBind();
        }

        protected  void ClearAll_Click(Object sender,  EventArgs e)
        {
            DataTable ds = new DataTable();
            ds = null;
            grdTable.DataSource = ds;
            grdTable.DataBind();
            Table1.Visible = true;
            TxtSearch.Text = string.Empty;

            txtSelectedJob.Text = string.Empty;
            txtB1.Enabled = false;
            btnReplicate.Enabled = false;
            btnPrint.Text = "Print";
            btnPrint.Enabled = false;
            // grdTable.Columns.Clear();
            //grdTable.Visible = true;
        }

        private List<GatepassDetails> _lstTempSearch;

        public List<GatepassDetails> LstTempSearch
        {
            get { return _lstTempSearch; }
            set { _lstTempSearch = value; }
        }

        protected void Search_Click1(Object sender,EventArgs e)
        {
            string pattern = @"^[a-zA-Z0-9]+$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(TxtSearch.Text))
            {
                string _searchFSNumber = TxtSearch.Text;
                if(ViewState["MainList"] != null)
                {

                    LstTempSearch = AddData();
                   
                    foreach (GatepassDetails obj in LstTempSearch)
                    {
                        if (_searchFSNumber.ToLower() == obj.JobNumber.ToLower())
                        {
                            GatepassDetails searchJoB = obj;
                            LstTempSearch.Clear();
                            LstTempSearch.Add(searchJoB);
                            grdTable.DataSource = LstTempSearch;
                            grdTable.DataBind();
                            TxtSearch.Text = string.Empty;
                            return;
                        }
                        else
                        {

                            ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('The Job Number Not Found');", true);
                        }
                    }
                }

            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Invalid Job Number');", true);
                    
            }

            TxtSearch.Text = string.Empty;


        }

        protected void OnPaging_changed(object sender, GridViewPageEventArgs e)
        {
            if (ViewState["MainList"] != null)
            {
                LstGatepassDetails = (List<GatepassDetails>)ViewState["MainList"];
                grdTable.PageIndex = e.NewPageIndex;
                grdTable.DataSource = LstGatepassDetails;
                grdTable.DataBind();
            }
            
        }

        void CustomersGridView_SelectedIndexChanged(Object sender, EventArgs e)
        {
            //// Get the currently selected row using the SelectedRow property.
            //GridViewRow row = grdTable.;

            //// Display the first name from the selected row.
            //// In this example, the third column (index 2) contains
            //// the first name.
            //MessageLabel.Text = "You selected " + row.Cells[2].Text + ".";
        }


        //private List<GatepassDetails> _lstRowSelected = new List<GatepassDetails>();

        //public List<GatepassDetails> LstRowSelected
        //{
        //    get { return _lstGatepassDetails; }
        //    set { _lstGatepassDetails = value; }
        //}
        int _count = 0;

        private List<GatepassDetails> _lstSelectedJobsForPrint;

        public List<GatepassDetails> LstSelectedJobsForPrint
        {
            get { return _lstSelectedJobsForPrint; }
            set
            {
                _lstSelectedJobsForPrint = value;
                Session["Jobs_selected"] = _lstSelectedJobsForPrint;
            }
        }

        protected void CheckboxSelected(Object sender, EventArgs e)
        {
            LstSelectedJobsForPrint = new List<GatepassDetails>();

            foreach (GridViewRow gvrow in grdTable.Rows)
            {
                CheckBox chk = (CheckBox)gvrow.FindControl("chk");

                if (chk != null && chk.Checked)
                {
                    string _job = gvrow.Cells[2].Text;
                    GatepassDetails obj = LstGatepassDetails.Find(x => x.JobNumber == _job);
                    LstSelectedJobsForPrint.Add(obj);

                    _count++;
                    if(_count == 1)
                    {
                        //string _job = gvrow.Cells[2].Text;
                        txtSelectedJob.Text = _job;
                        txtB1.Enabled = true;
                        btnReplicate.Enabled = true;
                    }
                    else
                    {
                        txtSelectedJob.Text = string.Empty;
                        txtB1.Enabled = false;
                        btnReplicate.Enabled = false;
                        btnPrint.Text = "Print";
                        //btnPrint.Enabled = false;
                    }
                   
                }
                else
                {
                    if (_count == 0)
                    {
                        //btnPrint.Enabled = false;
                        txtSelectedJob.Text = string.Empty;
                        txtB1.Enabled = false;
                        btnReplicate.Enabled = false;
                        btnPrint.Text = "Print";
                    }
                }
            } 
                      
        }


        protected void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            string pName = grdTable.SelectedRow.Cells[2].Text;
            //msg.Text = "<b>Publisher Name  &nbsp;:&nbsp;&nbsp;   " + pName + "</b>";

            //foreach (GridViewRow gvrow in grdTable.Rows)
            //{
            // grdTable.SelectedRow.Cells[0].is

            //bool _isprint = false;
            if (_count == 1 || _count == 0)
            {
                btnPrint.Enabled = true;
                foreach (GatepassDetails obj in LstGatepassDetails)
                {
                    if (pName == obj.JobNumber)
                    {
                        if (obj.IsPrint)
                        {
                            btnPrint.Text = "Re-Print";
                        }
                        else { btnPrint.Text = "Print"; }
                    }
                }
            }
        }

        protected override void Render(HtmlTextWriter writer)
        {
            foreach (GridViewRow r in grdTable.Rows)
            {
                if (r.RowType == DataControlRowType.DataRow)
                {
                    r.Attributes["onmouseover"] = "this.style.cursor='pointer';this.style.textDecoration='none';";
                    r.Attributes["onmouseout"] = "this.style.textDecoration='none';";
                    r.Attributes["onclick"] = this.Page.ClientScript.GetPostBackClientHyperlink(this.grdTable, "Select$" + r.RowIndex, true);

                }
            }

            base.Render(writer);
        }

        protected void Onsettingclick(object sender, EventArgs e)
        {
            Response.Redirect("Print.aspx");
        }

        private List<GatepassDetails> _lstReplicateList = new List<GatepassDetails>();

        public List<GatepassDetails> LstReplicateList
        {
            get { return _lstGatepassDetails; }
            set { _lstGatepassDetails = value; }
        }

        protected void onReplicateClick(object sender, EventArgs e)
        {
            if (txtB1.Text != string.Empty)
            {
                LstReplicateList = AddData();
                GatepassDetails obj = LstReplicateList.Find(x=>x.JobNumber == txtSelectedJob.Text);

                LstReplicateList.Clear();

                if (obj != null)
                {
                    GatepassDetails objReplicate;
                    int _noOfcopies = int.Parse(txtB1.Text);
                    int test = 1;
                    for (int i = 0; i < _noOfcopies; i++)
                    {
                        //int ivalue = i;
                        test = i;
                        objReplicate = new GatepassDetails();
                        objReplicate = obj;
                        objReplicate.B1 = _noOfcopies.ToString();
                        objReplicate.A1 = test.ToString();
                        LstReplicateList.Add(objReplicate);

                        grdTable.DataSource = LstReplicateList;
                        grdTable.DataBind();
                        test = 0;
                    }
             
                }

               

            }

        }

        private void AddDataListToDropDown()
        {

            //_lstGatepassDetails
           // drpJOBnumbers.DataSource = LstGatepassDetails;
           // drpJOBnumbers.DataTextField = "JobNumber";
           // drpJOBnumbers.DataValueField = "JobNumber";
            //drpJOBnumbers.DataBind();
        }


        protected void OnSubmitclick(object sender, EventArgs e)
        {
            if (ViewState["MainList"] != null)
            {
                txtSelectedJob.Text = string.Empty;
                txtB1.Enabled = false;
                btnReplicate.Enabled = false;
                btnPrint.Enabled = true;
                txtB1.Text = string.Empty;
                Table1.Visible = false;
                LstGatepassDetails = (List<GatepassDetails>)ViewState["MainList"];
                grdTable.AutoGenerateColumns = false;
                grdTable.DataSource = LstGatepassDetails;
                grdTable.DataBind();
                TxtSearch.Text = string.Empty;
            }
            
        }
    }
}
