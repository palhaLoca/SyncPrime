using Ninject;
using SyncPrime.Application.Services.Interfaces;
using SyncPrime.Application.ViewModel;
using SyncPrime.Domain.Enums;
using System;
using System.Linq;
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

        #region Controls
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
            cbTypeValues.DataSource = Enum.GetNames(typeof(CadEmun.TypedValue)).ToList();

        }

        private void cbTypeValues_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((CadEmun.TypedValue)cbTypeValues.SelectedIndex)
            {
                case CadEmun.TypedValue.LINE:
                    dtGridViewCurrentElements.DataSource = _serviceApp.GetCurrentLines();
                    break;
                /*case CadEmun.TypedValue.MTEXT:
                    dtGridViewCurrentElements.DataSource = _serviceApp.GetCurrentMText();
                    break;
                case CadEmun.TypedValue.LWPOLYLINE:
                    dtGridViewCurrentElements.DataSource = _serviceApp.GetCurrentLWPolyLine();
                    break;
                case CadEmun.TypedValue.INSERT:
                    dtGridViewCurrentElements.DataSource = _serviceApp.GetCurrentInsert();
                    break;
                default:
                    break;*/

            }
        }
        #endregion

        #region Methods

        #endregion
        #region Validations

        #endregion
    }
}
