using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App
{
    public partial class Form1 : Form
    {
        BindingList<Reader> Readers;
        BindingList<Tag> Tags;

        public Form1()
        {
            InitializeComponent();

            Readers = new BindingList<Reader>();
            Tags = new BindingList<Tag>();
            
            Readers.Add(new Reader() { Ip="192.168.1.12", Puerto= 5084 });
            Readers.Add(new Reader() { Ip = "192.168.1.11", Puerto = 5084 });

            Tags.Add(new Tag() { IdrFID = 1, Antena = 2, IdTag = "ASD210000020000" });
            Tags.Add(new Tag() { IdrFID = 2, Antena = 1, IdTag = "140000102000AEA" });
            Tags.Add(new Tag() { IdrFID = 1, Antena = 2, IdTag = "MISESPAÑALES012" });

            dgvReaders.DataSource = Readers;
            dgvTags.DataSource = Tags;


        }
        

        private void btnAgregarReader_Click(object sender, EventArgs e)
        {
            Readers.Add(new Reader() { Ip = txtIp.Text, Puerto = Int32.Parse(txtPuerto.Text) });
        }
    }
}
