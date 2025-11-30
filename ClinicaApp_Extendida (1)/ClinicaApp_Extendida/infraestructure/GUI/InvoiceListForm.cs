using System;
using System.Linq;
using System.Windows.Forms;
using ClinicaApp.Application.UseCases;
using ClinicaApp.Infraestructure.Persistence;

namespace ClinicaApp.Infraestructure.GUI
{
    public partial class InvoiceListForm : Form
    {
        private readonly BillingUseCase _billingUseCase;

        public InvoiceListForm()
        {
            InitializeComponent();

            // Botón de cerrar sesión en la barra superior (igual que en otros forms)
            LogoutUiHelper.AttachLogoutButton(this);

            _billingUseCase = ServiceLocator.CreateBillingUseCase();

            // Inicializar año de filtro al año actual
            nudFiltroAnio.Value = DateTime.Now.Year;

            // Cargar todas las facturas inicialmente
            CargarFacturas(null);
        }

        private void CargarFacturas(int? year)
        {
            var result = _billingUseCase.BuscarFacturasPorAnio(year);

            if (!result.Success && !string.IsNullOrWhiteSpace(result.Message))
            {
                MessageBox.Show(result.Message, "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dgvFacturas.AutoGenerateColumns = true;
            dgvFacturas.DataSource = result.Invoices
                .Select(i => new
                {
                    i.InvoiceId,
                    Fecha = i.InvoiceDate,
                    Paciente = i.Patient != null
                        ? i.Patient.NombreCompleto
                        : $"Paciente {i.PatientId}",
                    i.CedulaMedico,
                    i.CompanyName,
                    Total = i.TotalAmount,
                    i.Year
                })
                .ToList();

            LimpiarDetalle();
        }

        private void LimpiarDetalle()
        {
            txtPaciente.Text = string.Empty;
            txtFechaFactura.Text = string.Empty;
            txtTotal.Text = string.Empty;
            dgvDetalles.DataSource = null;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int year = (int)nudFiltroAnio.Value;
            CargarFacturas(year);
        }

        private void btnVerTodas_Click(object sender, EventArgs e)
        {
            CargarFacturas(null);
        }

        private void dgvFacturas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvFacturas.Rows[e.RowIndex];
            var val = row.Cells["InvoiceId"].Value?.ToString();
            if (string.IsNullOrWhiteSpace(val)) return;

            if (!int.TryParse(val, out var invoiceId)) return;

            var result = _billingUseCase.ObtenerFacturaConDetalle(invoiceId);
            if (!result.Success || result.Invoice == null)
            {
                MessageBox.Show(result.Message ?? "No se pudo cargar la factura.",
                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var inv = result.Invoice;

            txtPaciente.Text = inv.Patient != null
                ? inv.Patient.NombreCompleto
                : $"Paciente {inv.PatientId}";

            txtFechaFactura.Text = inv.InvoiceDate.ToString("dd/MM/yyyy");
            txtTotal.Text = inv.TotalAmount.ToString("N2");

            dgvDetalles.AutoGenerateColumns = true;
            if (inv.Details != null)
            {
                dgvDetalles.DataSource = inv.Details.Select(d => new
                {
                    d.Description,
                    d.Quantity,
                    d.UnitCost,
                    d.LineTotal,
                    d.ItemType
                }).ToList();
            }
            else
            {
                dgvDetalles.DataSource = null;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close(); // vuelve al MainForm sin cerrar sesión
        }
    }
}
