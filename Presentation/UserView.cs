using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Connection_DB;

namespace Presentation
{
    public partial class UserView : Form
    {
        Connection cn = new Connection();
        string id;
        public UserView()
        {
            InitializeComponent();
        }

        internal void load(string id2)
        {
            id = id2;
        }
    }
}
