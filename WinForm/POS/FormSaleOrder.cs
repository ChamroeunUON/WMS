using System;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using DevComponents.DotNetBar;
using FastMember;
using WinForm.Inventory.ProductMaster;
using WinForm.Models;
using WinForm.Models.Support;
using WinForm.Reports.ReceiveItems;
using WinForm.Reports.SaleOrderItem;

namespace WinForm.POS
{
    public partial class FormSaleOrder : Office2007Form
    {
        private int _idMax;
        private readonly AppContext _appContext;
        public FormSaleOrder()
        {
            _appContext = new AppContext();
            InitializeComponent();
        }


        private void FormSaleOrder_Load(object sender, EventArgs e)
        {
            txtUserId.Text = CurrentUser.GetCurrentUserId.ToString();
            txtUserName.Text = CurrentUser.GetCurrentUser;
            var settings = _appContext.Settings.First();
//            var saleCount = _appContext.SaleOrders.ToList();
//            _idMax = saleCount.Equals(null) ? 0 : saleCount.Count;
            txtSaleOrderID.Text = settings.SaleOrderPre + DateTime.Today.Year + DateTime.Today.Month.ToString("D2") +
                                  DateTime.Today.Day.ToString("D2") + _idMax.ToString("D3");    
        }


        private void tabPage2_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
//                dataGridView1.Rows[0].Cells[10].ReadOnly = true;
                if (e.ColumnIndex == 5)
                {
                    if (string.IsNullOrEmpty(txtWarehouseId.Text))
                    {
                        MyMessage.Warning("Please Select Warehouse!");
                        return;
                    }
                    if (string.IsNullOrEmpty(txtCustomerID.Text))
                    {
                        MyMessage.Warning("Please Select Customer!");
                        return;
                    }
                    var frm = new FormListProductWarehouse { WarehouseId = int.Parse(txtWarehouseId.Text) };
                    frm.ShowDialog();

                    foreach (var producWarehouse in frm.ProducWarehouse)
                    {
                        if (dataGridView1.Rows.Cast<DataGridViewRow>()
                            .TakeWhile(row => row.Cells[0].Value != null)
                            .Any(row => producWarehouse.ProductId == int.Parse(row.Cells[0].Value.ToString())))
                        {
                            MyMessage.Warning("Product already added");
                            return;
                        }
                        var dataGridViewRow = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                        dataGridViewRow.Cells[0].Value = producWarehouse.Product.Id;
                        dataGridViewRow.Cells[1].Value = producWarehouse.Product.NameEn;
                        dataGridViewRow.Cells[2].Value = producWarehouse.Product.NameKh;
                        dataGridViewRow.Cells[3].Value = producWarehouse.Product.Category.Name;
                        dataGridViewRow.Cells[4].Value = producWarehouse.Product.Measure.Name;
                        dataGridViewRow.Cells[6].Value = "1";
                        dataGridViewRow.Cells[7].Value = "0%";
                        dataGridViewRow.Cells[8].Value = "$ 0";
                        dataGridViewRow.Cells[9].Value = "0%";
                        dataGridViewRow.Cells[10].Value = producWarehouse.Product.Price.ToString("C");
                        // Set default QTY = 1 => amount = Price
                        dataGridViewRow.Cells[11].Value = producWarehouse.Product.Price.ToString("C");
                        dataGridViewRow.Cells[12].Value = producWarehouse.Product.Note;
                        if (e.RowIndex == dataGridView1.RowCount - 1)
                            dataGridView1.Rows.Add(dataGridViewRow);

                    }
                }
                
            }
            catch (Exception exception)
            {
                MyMessage.Error(exception.ToString());
            }
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            var frm = new FormListCustomer();
            frm.ShowDialog();
            txtCustomerID.Text = frm.CustomerId.ToString();
            txtCustomerName.Text = frm.CustomerName;
        }
        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            var frm = new FormListWarehouse();
            frm.ShowDialog();
            txtWarehouseId.Text = frm.WarehouseId.ToString();
            txtWarehouseName.Text = frm.WarehouseName;
        }

        private void dataGridView1_CellContentEndEdit(object sender, DataGridViewCellEventArgs e)
        {
//            var e.ColumnIndex = e.ColumnIndex;
            
            switch (e.ColumnIndex)
            {

                case 6:
                case 7:
                case 9:
                    if (dataGridView1.Rows.Count > 0)
                    {
                        var rowIndex = dataGridView1.CurrentCell.RowIndex;
                        
                        float pr = 0;
                        var price = dataGridView1.Rows[rowIndex].Cells[10].Value.ToString().Replace("$",null);
                        pr = float.Parse(price);

                        var qty = float.Parse(dataGridView1.Rows[rowIndex].Cells[6].Value.ToString());
                        
                        float di = 0;
                        var dis =  dataGridView1.Rows[rowIndex].Cells[7].Value.ToString().Replace("%",null);
                        di = float.Parse(dis);

                        float vi = 0;
                        var vat = dataGridView1.Rows[rowIndex].Cells[9].Value.ToString().Replace("%",null);
                        vi = float.Parse(vat);

                        var tmpAmount = qty * pr;
                        var amountVat = (vi / 100 ) * tmpAmount ;
                        var discont = (di / 100) * tmpAmount;                        
                        var amount = tmpAmount - discont + amountVat;

                        dataGridView1.Rows[rowIndex].Cells[11].Value = amount.ToString("C");
                        dataGridView1.Rows[rowIndex].Cells[10].Value = pr.ToString("C");
                        dataGridView1.Rows[rowIndex].Cells[8].Value = discont.ToString("C");
                        dataGridView1.Rows[rowIndex].Cells[7].Value = di + "%";
                        dataGridView1.Rows[rowIndex].Cells[9].Value = vi + "%";

                         float sum = 0;
                        for (var row = 0; row < dataGridView1.Rows.Count-1; row++)
                        {
                            var amt = float.Parse(dataGridView1.Rows[row].Cells[11].Value.ToString().Replace("$", ""));
                            sum += amt;
                        }
                        txtSubtotal.Text = sum.ToString("C");
                        if (string.IsNullOrEmpty(txtDiscountP.Text))
                        {
                            txtDiscountP.Text = @"0%";
                        }
                        var subTotal = float.Parse(txtSubtotal.Text.Replace("$", ""));
                        var percent = float.Parse(txtDiscountP.Text.Replace("%", ""));
                        var disA = (percent / 100) * subTotal;
                        var balance = subTotal - disA;
                        txtDisAmount.Text = disA.ToString("C");
                        txtBalance.Text = balance.ToString("C");
                        txtGrandTotal.Text = balance.ToString("C");
                        txtDeposit.Text = @"0 $";
                        txtDiscountP.Text = percent + @"%";
                    }
                    break;
                default:
                    return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtDiscountP_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDiscountP.Text))
            {
                txtDiscountP.Text = @"0%";
                return;
            }
            var subTotal = float.Parse(txtSubtotal.Text.Replace("$", ""));
            var percent = float.Parse(txtDiscountP.Text.Replace("%", ""));
            var disA = (percent / 100) * subTotal;
            var balance = subTotal - disA;
            txtDisAmount.Text = disA.ToString("C");
            txtBalance.Text = balance.ToString("C");
            txtGrandTotal.Text = balance.ToString("C");
            txtDeposit.Text = @"0 $";
            txtDiscountP.Text = percent + @"%";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
//            var salrOrder = SalrOrder;
//            _appContext.SaleOrders.Add(salrOrder);
//            for (var rowIndex = 0; rowIndex < dataGridView1.RowCount - 1; rowIndex++)
//            {
//                var saleOrderItem = SaleOrderItem(rowIndex);
//                _appContext.SaleOrderItems.Add(saleOrderItem);
//
//                /* Save into Productwarehouse */
//                var wareId = int.Parse(txtWarehouseId.Text);
//                var proId = int.Parse(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString());
//                var producWarehouse = _appContext.ProducWarehouses.Find(proId, wareId);
//                // Check Product Onhand Each ProductWarehouse
//                var onHand = producWarehouse != null ? int.Parse(producWarehouse.OnHand.ToString()) : 0;
//                if (onHand == 0)
//                {
//                    MyMessage.Warning("No Product in this warehouse");
//                    return;
//                }
//                if (producWarehouse != null)
//                {
//                    var alert = int.Parse(producWarehouse.AlertQty.ToString());
//                    if (onHand < alert)
//                        MyMessage.Success("Qty is low");
//                }
//                var saleOrderQty = producWarehouse != null ? int.Parse(producWarehouse.SaleOrderQty.ToString()) : 0;
//                // Check Product have or not in ProductWarehouse if null Adding if not null will Modified 
//                if (producWarehouse == null) continue;
//                onHand = onHand - int.Parse(dataGridView1.Rows[rowIndex].Cells[6].Value.ToString());
//                saleOrderQty = saleOrderQty + int.Parse(dataGridView1.Rows[rowIndex].Cells[6].Value.ToString());
//                producWarehouse.OnHand = onHand;
//                producWarehouse.SaleOrderQty = saleOrderQty;
//                _appContext.Entry(producWarehouse).State = EntityState.Modified;
//            }
//            _appContext.SaveChanges();
//            var dialog = MessageBox.Show("Do you want to print report", "Information", MessageBoxButtons.YesNo,
//                MessageBoxIcon.Information);
//            if (dialog == DialogResult.Yes)
//            {
//                var cId = int.Parse(txtCustomerID.Text);
//                var uId = int.Parse(txtUserId.Text);
//                var saleOrder = _appContext.SaleOrders
//                    .Where(id => id.SaleOrderId.Equals(txtSaleOrderID.Text))
//                    .Include(user => user.User)
////                    .Include(customer => customer.Customer)
//                    .Select(s => new
//                    {
//                        SaleOrderId = s.SaleOrderId,
//                        UserName = s.User.UserNmae,
////                        CustomerName = s.Customer.Name,
////                        CustomerId = s.CustomerId,
//                        SubTotal = s.SubTotal
////                        SubTotal = s.SubTotal
////                        Balance = s.Balance,
////                        Percent = s.DisPercent,
////                        Deposit = s.Deposit,
////                        GrandTotal = s.GrandTotal,
////                        DisAmount = s.DisAmount,
////                        Note =s.Note
//                    })
//                    .ToList();
//                var saleOrderItem = _appContext.SaleOrderItems
//                    .Where(saleOrderId => saleOrderId.SaleOrderId == txtSaleOrderID.Text)
//                    .Include(pw => pw.ProducWarehouse.Product)
//                    .Include(cat => cat.ProducWarehouse.Product.Category)
//                    .Include(m => m.ProducWarehouse.Product.Measure)
//                    .Include(w => w.ProducWarehouse.Warehouse)
//                    .Select(si => new
//                    {
//                       ProId = si.ProducWarehouse.ProductId,
//                       ProNameEn = si.ProducWarehouse.Product.NameEn,
//                       ProNameKh = si.ProducWarehouse.Product.NameKh,
//                       Category = si.ProducWarehouse.Product.Category.Name,
//                       Measure = si.ProducWarehouse.Product.Measure.Name,
//                       Qty = si.Qty,
//                       DisPercent = si.DisPercent,
//                       Price = si.Price,
//                       VAT = si.VatPercent,
//                       Amount = si.Amount
//                    })
//                    .ToList();

//                var dtSaleOrder = new DataTable();
//                using (var reader = ObjectReader.Create(saleOrder))
//                {
//                    dtSaleOrder.Load(reader);
//                }
//                dtSaleOrder.TableName = "SaleOrder";

//                var dtSaleOrderItem = new DataTable();
//                using (var reader = ObjectReader.Create(saleOrderItem))
//                {
//                    dtSaleOrderItem.Load(reader);
//                }
//                dtSaleOrderItem.TableName = "SaleOrderItem";
//
//                var ds = new dsSaleOrder();
//                ds.Merge(dtSaleOrder);
////                ds.Merge(dtSaleOrderItem);
//                var crptSaleOrder = new crptSaleOrder();
//                crptSaleOrder.SetDataSource(ds);
//                var frm = new FormSaleOrderReport(crptSaleOrder);
//                frm.ShowDialog();
//            }
//
//            MyMessage.Success("Saved");

        }

//        private SaleOrder SalrOrder
//        {
//            get
//            {
//                var salrOrder = new SaleOrder
//                {
//                    SaleOrderId = txtSaleOrderID.Text,
//                    SaleDate = Convert.ToDateTime(Convert.ToDateTime(dateSaleOrder.Text).ToShortDateString()),
////                    CustomerId = Convert.ToInt32(txtCustomerID.Text),
//                    UserId = CurrentUser.GetCurrentUserId,
//                    SaleType = SaleType.SaleOrder,
//                    SubTotal = float.Parse(txtSubtotal.Text.Replace("$", "")),
//                    DisPercent = float.Parse(txtDiscountP.Text.Replace("%", "")),
//                    DisAmount = float.Parse(txtDisAmount.Text.Replace("$", "")),
//                    Balance = float.Parse(txtBalance.Text.Replace("$", "")),
//                    Deposit = float.Parse(txtDeposit.Text.Replace("$", "")),
//                    GrandTotal = float.Parse(txtGrandTotal.Text.Replace("$", "")),
//                    Status = "New",
//                    Note = ""
//                };
//                return salrOrder;
//            }
//        }

//        private SaleOrderItem SaleOrderItem(int rowIndex)
//        {
//            var per = dataGridView1.Rows[rowIndex].Cells[7].Value.ToString();
//            var vat = dataGridView1.Rows[rowIndex].Cells[9].Value.ToString();
//            var pr = dataGridView1.Rows[rowIndex].Cells[10].Value.ToString();
//            var am = dataGridView1.Rows[rowIndex].Cells[11].Value.ToString();
//            var saleOrderItem = new SaleOrderItem
//            {
//                SaleOrderId = txtSaleOrderID.Text,
////                ProductId = int.Parse(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString()),
//                Qty = int.Parse(dataGridView1.Rows[rowIndex].Cells[6].Value.ToString()),
//                DisPercent = float.Parse(per.Replace("%", null)),
//                VatPercent = float.Parse(vat.Replace("%", null)),
//                Price = float.Parse(pr.Replace("$", null)),
//                Amount = float.Parse(am.Replace("$", null)),
////                WarehouseId = Convert.ToInt32(txtWarehouseId.Text),
//                Note = dataGridView1.Rows[rowIndex].Cells[12].Value.ToString()
//            };
//            return saleOrderItem;
//        }
    }
}
