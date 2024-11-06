using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultaCDR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tx_ruc.MaxLength = 11;
            tx_serie.MaxLength = 4;
            tx_serie.CharacterCasing = CharacterCasing.Upper;
            tx_numero.MaxLength = 8;
        }

        private void bt_proc_Click(object sender, EventArgs e)
        {
            if (tx_ruc.Text == "")
            {
                tx_ruc.Focus(); 
                return;
            }
            if (tx_serie.Text == "")
            {
                tx_serie.Focus();
                return;
            }
            if (tx_numero.Text == "")
            {
                tx_numero.Focus();
                return;
            }
            /* if (tx_base64.Text == "")
            {
                tx_base64.Focus();
                return;
            } */
            if (tx_ruta.Text == "")
            {
                bt_destino.Focus();
                return;
            }
            // actualizaCdr(tx_numero.Text, "01", tx_serie.Text, tx_ruta.Text) == true
            if (descargaCDR(tx_ruc.Text, tx_numero.Text, "01", tx_serie.Text, tx_ruta.Text) == true)
            {
                MessageBox.Show("Se genero el CDR zipeado con exito", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error en la generaci[on del CDR", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tx_base64.Clear();
            tx_numero.Clear();
            tx_serie.Clear();
            tx_ruc.Clear();
            tx_ruta.Clear();
            tx_codRpta.Clear();
            tx_deta.Clear();
        }
        private void bt_destino_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "Seleccione la ruta del destino";
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer;
            folderBrowserDialog1.ShowDialog();
            tx_ruta.Text = folderBrowserDialog1.SelectedPath;
        }
        private bool actualizaCdr(string numComp, string codComSunat, string serComp, string ruta)     // consulta CDR en F,B y NC
        {
            bool exito = false;
            /* string numComp = dgv_sunat_est.Rows[RowIndex].Cells["COMPROBANTE"].Value.ToString().Substring(5, 8);
            Byte[] respuesta = null;
            ServiceConsultaCDR.billServiceClient ws = new ServiceConsultaCDR.billServiceClient();
            ws.Open();
            respuesta = ws.getStatusCdr(Program.ruc, codComSunat, serComp, int.Parse(numComp)).content;
            ws.Close();
            */
            // Si hay un archivo de respuesta con ese nombre ... lo borramos!
            string aZip = ruta + "\\" + tx_ruc.Text + "-" + codComSunat + "-" + serComp + "-" + numComp + ".zip";
            string aXml = ruta + "\\" + tx_ruc.Text + "-" + codComSunat + "-" + serComp + "-" + numComp + ".xml";
            if (File.Exists("R-" + aZip) == true)
            {
                File.Delete("R-" + aZip);
            }
            //byte[] bytes = Encoding.ASCII.GetBytes(tx_base64.Text);
            byte[] bytes = Convert.FromBase64String(tx_base64.Text);
            // Creamos, escribimos la respuesta zipeada en la ruta establecida
            //FileStream fstrm = new FileStream("R-" + aZip, FileMode.CreateNew, FileAccess.Write);
            //fstrm.Write(bytes, 0, bytes.Length);
            //fstrm.Close();
            File.WriteAllBytes(aZip, bytes);
            exito = true;
            /* Extraemos el xml desde dentro del zip
            System.IO.Compression.ZipFile.ExtractToDirectory(rutaxml + "R-" + aZip, @"c:/temp/");
            FileStream archiS = new FileStream(@"c:/temp/" + "R-" + aXml, FileMode.Open, FileAccess.Read);        // @"c:/temp/" + archi, FileMode.Open, FileAccess.Read
            XmlDocument archiXml = new XmlDocument();
            archiXml.Load(archiS);
            XmlNode idx = archiXml.GetElementsByTagName("ID", "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2").Item(0);
            XmlNode fex = archiXml.GetElementsByTagName("ResponseDate", "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2").Item(0);
            XmlNode hex = archiXml.GetElementsByTagName("ResponseTime", "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2").Item(0);
            string fhx = fex.InnerText.ToString() + " " + hex.InnerText.ToString();
            XmlNode fqr = archiXml.GetElementsByTagName("DocumentResponse", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2").Item(0);
            archiS.Close();
            File.Delete(@"c:/temp/" + "R-" + aXml);     // borramos el xml del temporal
            string res2 = "", res3 = "";
            if (fqr == null)
            {
                XmlNode fer = archiXml.GetElementsByTagName("Description", "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2").Item(0);
                // esta parte falta .. cuando el comprobante es rechazado 07/09/23
                // ...........
                // acá me quede 11/09/2023 .... sigue faltando al 16/07/2024
                // .............
            }
            else
            {
                //res1 = fqr.FirstChild.ChildNodes.Item(0).InnerText;
                res2 = fqr.FirstChild.ChildNodes.Item(1).InnerText;
                res3 = fqr.FirstChild.ChildNodes.Item(2).InnerText;
                using (MySqlConnection conn = new MySqlConnection(DB_CONN_STR))
                {
                    conn.Open();
                    string actua = "update adifactu set nticket=@nti,fticket=@fti,estadoS=@est,cdr=@cdrt,cdrgener=@cdrg,textoQR=@tqr " +
                        "where idc=@idc and tipdoc=@tipdoc";
                    using (MySqlCommand micon = new MySqlCommand(actua, conn))
                    {
                        micon.Parameters.AddWithValue("@idc", dgv_sunat_est.Rows[RowIndex].Cells["id"].Value.ToString());    // tx_idr.Text
                        micon.Parameters.AddWithValue("@nti", idx.InnerText.ToString());
                        micon.Parameters.AddWithValue("@fti", fhx);
                        micon.Parameters.AddWithValue("@est", (res2 == "0") ? "Aceptado" : "Rechazado");
                        micon.Parameters.AddWithValue("?cdrt", respuesta);  // respuesta zipeada de Sunat
                        micon.Parameters.AddWithValue("@cdrg", res2);
                        micon.Parameters.AddWithValue("@tqr", res3);
                        micon.Parameters.AddWithValue("@tipdoc", dgv_sunat_est.Rows[RowIndex].Cells["tipdvta"].Value.ToString());
                        micon.ExecuteNonQuery();
                    }
                }
            }
            */
            return exito;
        }
        private bool descargaCDR(string Nruc, string numComp, string codComSunat, string serComp, string ruta)
        {
            bool exito = false;

            Byte[] contenido = null;
            ConsultaCDRsunat.billServiceClient ws = new ConsultaCDRsunat.billServiceClient();
            var respuesta = ws.getStatusCdr(Nruc, codComSunat, serComp, int.Parse(numComp));
            ws.Close();
            tx_codRpta.Text = respuesta.statusCode.ToString();
            tx_deta.Text = respuesta.statusMessage;
            string aZip = ruta + "\\" + "R-" + tx_ruc.Text + "-" + codComSunat + "-" + serComp + "-" + numComp + ".zip";
            contenido = respuesta.content;
            if (tx_codRpta.Text == "0004")
            {
                if (File.Exists(aZip) == true)
                {
                    File.Delete(aZip);
                }
                // Creamos, escribimos la respuesta zipeada en la ruta establecida
                FileStream fstrm = new FileStream(aZip, FileMode.CreateNew, FileAccess.Write);
                fstrm.Write(contenido, 0, contenido.Length);
                fstrm.Close();
                exito = true;
            }

            return exito;
        }
        private void tx_ruc_Validating(object sender, CancelEventArgs e)
        {
            if(tx_ruc.Text.Length != 11 && tx_ruc.Text.Length > 0)
            {
                errorProvider1.SetError(label1,"El ruc debe tener 11 caracteres");
                tx_ruc.Focus();
                return;
            }
            else { errorProvider1.Dispose(); }
        }
        private void tx_serie_Validating(object sender, CancelEventArgs e)
        {
            if (tx_serie.Text.Length != 4 && tx_serie.Text.Length > 0)
            {
                errorProvider1.SetError(label2, "La serie debe tener 4 digitos iniciando con B o F");
                tx_serie.Focus();
                return;
            }
            else { errorProvider1.Dispose(); }
        }
        private void tx_numero_Validating(object sender, CancelEventArgs e)
        {
            // nada
        }

    }
}
