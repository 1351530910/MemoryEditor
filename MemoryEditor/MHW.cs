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

namespace MemoryEditor
{
    public partial class MHW : Form
    {
        Process mhw;
        IntPtr handle;
        ulong baseAddress;

        int gold = 1161630;
        int sp = 56865;
        int level;
        int exp;

        public MHW()
        {
            InitializeComponent();
            mhw = Process.GetProcessesByName("MonsterHunterWorld").FirstOrDefault() ?? throw new Exception("process not found");
            handle = mhw.Handle;
            gold_tb.Text = gold.ToString();
            SP_tb.Text = sp.ToString();
        }

        private void update()
        {
            gold_tb.Text = gold.ToString();
            SP_tb.Text = sp.ToString();
            exp_tb.Text = exp.ToString();
            level_tb.Text = level.ToString();
        }

        private void Scan_Click(object sender, EventArgs e)
        {
            gold = int.Parse(gold_tb.Text);
            sp = int.Parse(SP_tb.Text);

            var keyword = ((ulong)sp << 32) + (ulong)gold;
            UIntPtr[] addresses = new UIntPtr[1];
            var n = ProcessIO.MemSearch(handle, BitConverter.GetBytes(keyword), 8, addresses, 1);
            if (n >= 1) baseAddress = addresses[0].ToUInt64();
            exp = ProcessIO.ReadInt32(handle, baseAddress + 8);
            level = ProcessIO.ReadInt32(handle, baseAddress - 4);
            update();
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

    }
}
