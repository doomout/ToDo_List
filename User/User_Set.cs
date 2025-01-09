using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDo_List.User
{
    public partial class User_Set : Form
    {
        private string userId;
        public User_Set(string userId)
        {
            InitializeComponent();
            this.userId = userId;
            this.lbl_id.Text += $"{userId}";
        }
    }
}
