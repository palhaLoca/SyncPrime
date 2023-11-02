using Ninject;
using SyncPrime.Application.Services.Interfaces;
using SyncPrime.Application.ViewModel;
using System;
using System.Windows.Forms;

namespace SyncPrime
{
    public partial class Home : Form
    {
        private IServiceApp _serviceApp;
        public Home()
        {
            InitializeComponent();
            _serviceApp = Startup.stdKernel.Get<IServiceApp>();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _serviceApp.Save(
                new LineViewModel
                {
                    endPtX = double.Parse(txtBoxEndPtX.Text),
                    endPtY = double.Parse(txtBoxEndPtY.Text),
                    startPtX = double.Parse(txtBoxStartPtX.Text),
                    startPtY = double.Parse(txtBoxStartPtY.Text),
                    layer = txtBoxLayer.Text
                });

            dtGridViewLines.DataSource = _serviceApp.GetLines();
            MessageBox.Show("Registro criado!");
        }

        private void Home_Load(object sender, EventArgs e)
        {
            dtGridViewLines.DataSource = _serviceApp.GetLines();
        }
    }
}
