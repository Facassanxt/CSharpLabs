using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labSqlLite
{
    public partial class Form1 : Form
    {
        private SQLiteConnection db;
        public Form1()
        {
            InitializeComponent();

            db = new SQLiteConnection("myDB.db");
            db.CreateTable<Logs>();
            db.CreateTable<Users>();
            db.CreateTable<Notes>();
            db.Insert(new Logs() { DT = DateTime.Now });
            lvLogs.Columns.Add("DateTime", 220);
            lvLogs.View = View.Details;
            foreach (var item in db.Table<Logs>())
            {
                lvLogs.Items.Add(item.DT.ToString());
            }
            buUsersShow.Click += (s, e) => dataGridView1.DataSource = db.Table<Users>().ToList();
            buNotesShow.Click += (s, e) => dataGridView1.DataSource = db.Table<Notes>().ToList();

            buNotesAdd.Click += BuNotesAdd_Click;
            buRunOne.Click += (s, e) => MessageBox.Show(db.ExecuteScalar<int>(edSQL.Text).ToString());
        }

        /*TODO HW
         * добавление, редактирование, удаление данных из таблицы
         * обновление данных в таблице 
         * 
         * 
         * 
         */

        private void BuNotesAdd_Click(object sender, EventArgs e)
        {
            var x = new Notes();
            x.Caption = edNotesCaption.Text;
            x.Priority = (byte)edNotesPriority.Value;
            db.Insert(x);
            dataGridView1.DataSource = db.Table<Notes>().ToList();
        }

        private class Logs
        {
            public DateTime DT { get; set; }
        }

        private class Users
        {
            [PrimaryKey, AutoIncrement]
            public int ID { get; set; }
            public string FIO { get; set; }
            public string Email { get; set; }
            public string Age { get; set; }

        }

        private class Notes
        {
            [PrimaryKey, AutoIncrement]
            public int ID { get; set; }
            public string Caption { get; set; }
            public byte Priority { get; set; }
        }
    }
}
