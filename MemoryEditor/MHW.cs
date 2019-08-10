using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace MemoryEditor
{
    
    public partial class MHW : Form
    {
        Process mhw = null;
        IntPtr handle;
        ulong baseAddress;
        
        int gold;
        int sp;
        int level;
        int exp;

        Item[] inventoryItems = new Item[24];
        Item[] inventoryAmmo = new Item[16];
        Item[] stockItems = new Item[150];
        Item[] stockAmmo = new Item[100];
        Item[] stockMaterials = new Item[390];
        Item[] stockGems = new Item[150];

        static List<Item> locks = new List<Item>();
        public MHW()
        {
            InitializeComponent();
            dataGridView1.AllowUserToAddRows = false;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            gold_tb.Text = gold.ToString();
            SP_tb.Text = sp.ToString();
            comboBox1.Items.Add("Inventory Items");
            comboBox1.Items.Add("Inventory Ammo");
            comboBox1.Items.Add("Stock Items");
            comboBox1.Items.Add("Stock Ammo");
            comboBox1.Items.Add("Stock Materials");
            comboBox1.Items.Add("Stock Gems");
            comboBox1.SelectedIndex = 2;
            new Thread(() => checklock(this)).Start();
            this.dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            System.Environment.Exit(0);
        }

        private void checklock(Form a)
        {
            while (true)
            {
                for (int i = 0; i < locks.Count; i++)
                {
                    try
                    {
                        var item = locks[i];
                        ProcessIO.WriteInt32(handle, item.address, item.id);
                        ProcessIO.WriteInt32(handle, item.address + 4, item.count);
                        Thread.Sleep(100);
                    }
                    catch (Exception) { }
                }

                Thread.Sleep(1000);
            }
        }

        private void update()
        {
            gold_tb.Text = gold.ToString();
            SP_tb.Text = sp.ToString();
            exp_tb.Text = exp.ToString();
            level_tb.Text = level.ToString();
            ComboBox1_SelectedIndexChanged(null, null);
        }
        private void DataGridView1_CellValueChanged(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (mhw==null)
            {
                return;
            }
            if (e.ColumnIndex == 4)
            {
                if ((bool)dataGridView1.CurrentCell.EditedFormattedValue)
                {
                    ((Item[])dataGridView1.DataSource)[e.RowIndex].locked = true;
                    locks.Add(((Item[])dataGridView1.DataSource)[e.RowIndex]);

                }
                else
                {
                    locks.Remove(((Item[])dataGridView1.DataSource)[e.RowIndex]);
                    ((Item[])dataGridView1.DataSource)[e.RowIndex].locked = false;
                }
            }
            if (e.ColumnIndex == 2 && ((Item[])dataGridView1.DataSource)[e.RowIndex].locked == false)
            {
                var item = ((Item[])dataGridView1.DataSource)[e.RowIndex];
                ProcessIO.WriteInt32(handle, item.address + 4, int.Parse((string)dataGridView1.CurrentCell.EditedFormattedValue));
                ((Item[])dataGridView1.DataSource)[e.RowIndex].count = int.Parse((string)dataGridView1.CurrentCell.EditedFormattedValue);
            }
            if (e.ColumnIndex == 0 && ((Item[])dataGridView1.DataSource)[e.RowIndex].locked == false)
            {
                var item = ((Item[])dataGridView1.DataSource)[e.RowIndex];
                ProcessIO.WriteInt32(handle, item.address, int.Parse((string)dataGridView1.CurrentCell.EditedFormattedValue));
                ((Item[])dataGridView1.DataSource)[e.RowIndex].id = int.Parse((string)dataGridView1.CurrentCell.EditedFormattedValue);
            }
        }
        private void DataGridView1_CellEndEdit(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            
        }
        private void DataGridView1_CellValidating(object sender, System.Windows.Forms.DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                if ((bool)e.FormattedValue)
                {
                    locks.Add(((Item[])dataGridView1.DataSource)[e.RowIndex]);
                }
                else
                {
                    locks.Remove(((Item[])dataGridView1.DataSource)[e.RowIndex]);
                }
            }
            if (e.ColumnIndex < 3 && ((Item[])dataGridView1.DataSource)[e.RowIndex].locked==false)
            {
                var item = ((Item[])dataGridView1.DataSource)[e.RowIndex];
                ProcessIO.WriteInt32(handle, item.address, item.id);
                ProcessIO.WriteInt32(handle, item.address + 4, item.count);
            }
            
            return;
        }
        private void refreshMem()
        {
            gold = ProcessIO.ReadInt32(handle, baseAddress);
            sp = ProcessIO.ReadInt32(handle, baseAddress + 4);
            exp = ProcessIO.ReadInt32(handle, baseAddress + 8);
            level = ProcessIO.ReadInt32(handle, baseAddress - 4);

            for (ulong i = 0; i < (ulong)inventoryItems.Length; i++)
            {
                inventoryItems[i].address = baseAddress + 0x1945c + i * 0x10;
                inventoryItems[i].id = ProcessIO.ReadInt32(handle, inventoryItems[i].address);
                inventoryItems[i].count = ProcessIO.ReadInt32(handle, inventoryItems[i].address + 4);
            }
            for (ulong i = 0; i < (ulong)inventoryAmmo.Length; i++)
            {
                inventoryAmmo[i].address = baseAddress + 0x195dc + i * 0x10;
                inventoryAmmo[i].id = ProcessIO.ReadInt32(handle, inventoryAmmo[i].address);
                inventoryAmmo[i].count = ProcessIO.ReadInt32(handle, inventoryAmmo[i].address + 4);
            }
            for (ulong i = 0; i < (ulong)stockItems.Length; i++)
            {
                stockItems[i].address = baseAddress + 0x19dd4 + i * 0x10;
                stockItems[i].id = ProcessIO.ReadInt32(handle, stockItems[i].address);
                stockItems[i].count = ProcessIO.ReadInt32(handle, stockItems[i].address + 4);
            }
            for (ulong i = 0; i < (ulong)stockAmmo.Length; i++)
            {
                stockAmmo[i].address = baseAddress + 0x1aa54 + i * 0x10;
                stockAmmo[i].id = ProcessIO.ReadInt32(handle, stockAmmo[i].address);
                stockAmmo[i].count = ProcessIO.ReadInt32(handle, stockAmmo[i].address + 4);
            }
            for (ulong i = 0; i < (ulong)stockMaterials.Length; i++)
            {
                stockMaterials[i].address = baseAddress + 0x1b6d4+i * 0x10;
                stockMaterials[i].id = ProcessIO.ReadInt32(handle, stockMaterials[i].address);
                stockMaterials[i].count = ProcessIO.ReadInt32(handle, stockMaterials[i].address+4);
            }
            for (ulong i = 0; i < (ulong)stockGems.Length; i++)
            {
                stockGems[i].address = baseAddress + 0x1e8d4 + i * 0x10;
                stockGems[i].id = ProcessIO.ReadInt32(handle, stockGems[i].address);
                stockGems[i].count = ProcessIO.ReadInt32(handle, stockGems[i].address + 4);
            }

            update();
        }

        private void Scan_Click(object sender, EventArgs e)
        {
            mhw = Process.GetProcessesByName("MonsterHunterWorld").FirstOrDefault() ?? throw new Exception("process not found");
            handle = mhw.Handle;
            gold = int.Parse(gold_tb.Text);
            sp = int.Parse(SP_tb.Text);

            var keyword = ((ulong)sp << 32) + (ulong)gold;
            UIntPtr[] addresses = new UIntPtr[1000];
            var n = ProcessIO.MemSearch(handle, BitConverter.GetBytes(keyword), 8, addresses, 1000);
            if (n >= 1) baseAddress = addresses[0].ToUInt64();
            else return;
            refreshMem();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            gold = int.Parse(gold_tb.Text);
            sp = int.Parse(SP_tb.Text);
            exp = int.Parse(exp_tb.Text);
            level = int.Parse(level_tb.Text);
            ProcessIO.WriteInt32(handle, baseAddress - 4, level);
            ProcessIO.WriteInt32(handle, baseAddress, gold);
            ProcessIO.WriteInt32(handle, baseAddress +4, sp);
            ProcessIO.WriteInt32(handle, baseAddress +8, exp);
        }


        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            refreshMem();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            if (mhw==null)
                return;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    dataGridView1.DataSource = inventoryItems;
                    return;
                case 1:
                    dataGridView1.DataSource = inventoryAmmo;
                    return;
                case 2:
                    dataGridView1.DataSource = stockItems;
                    return;
                case 3:
                    dataGridView1.DataSource = stockAmmo;
                    return;
                case 4:
                    dataGridView1.DataSource = stockMaterials;
                    return;
                case 5:
                    dataGridView1.DataSource = stockGems;
                    return;
                default:
                    break;
            }
        }

        private void BindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Set_btn_Click(object sender, EventArgs e)
        {
            gold = int.Parse(gold_tb.Text);
            sp = int.Parse(SP_tb.Text);
            exp = int.Parse(exp_tb.Text);
            level = int.Parse(level_tb.Text);
            ProcessIO.WriteInt32(handle, baseAddress, gold);
            ProcessIO.WriteInt32(handle, baseAddress + 4, sp);
            ProcessIO.WriteInt32(handle, baseAddress + 8, exp);
            ProcessIO.WriteInt32(handle, baseAddress - 4, level);
        }

        private void LockAll_Click(object sender, EventArgs e)
        {
            Refresh_btn_Click(null, null);
            dataGridView1.Visible = !dataGridView1.Visible;
            if (dataGridView1.Visible)
            {
                locks.RemoveAll(x => true);
            }
            else
            {
                locks.RemoveAll(x => true);
                locks.AddRange(inventoryItems.Where(x => x.id != 0));
                locks.AddRange(inventoryAmmo.Where(x => x.id != 0));
            }
            
        }
    }
    public struct Item
    {
        public int id { get; set; }
        public string name { get; set; }
        public int count { get; set; }
        public ulong address { get; set; }
        public bool locked { get; set; }
    }
}
