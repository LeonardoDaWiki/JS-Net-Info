using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Net.NetworkInformation;
using System.Net;
using System.IO;
using System.Net.Sockets;

namespace JSNetInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
            this.ddl_Language.SelectedIndex = 0;
        }

        #region "erneuern..."-Button
        // Button "Info auslesen" -> Die Werte werden in die Textboxen geladen

        private void btn_InfosAuslesen_Click(object sender, EventArgs e)
        {
            txb_IPAdresse.Text = null;
            txb_Gateway.Text = null;
            txb_DNSServer.Text = null;

            txb_IPAdresse.Text = GetIPv4Address();
            txb_Gateway.Text = GetDefaultGateway().ToString();
            txb_DNSServer.Text = GetDnsAdress().ToString();
            txb_MACAdresse.Text = GetMACAddress();
        }
        #endregion

        #region MACAdresse
        // Die MAC-Adresse wird ausgelesen

        private string GetMACAddress()
        {
            string macAddresses = string.Empty;

            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus == OperationalStatus.Up)
                {
                    macAddresses += nic.GetPhysicalAddress().ToString();
                    break;
                }
            }

            return macAddresses;
        }
        #endregion

        #region IPAdresse
        // Die IP-Adresse wird ausgelesen

        private string GetIPv4Address()
        {
            string strHostName = "";
            strHostName = System.Net.Dns.GetHostName();

            IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(strHostName);

            IPAddress[] addr = ipEntry.AddressList;

            return addr[addr.Length - 1].ToString();
        }
        #endregion

        #region Subnetzmaske
        // Auslesen der Subnetzmaske

        public static IPAddress GetDefaultGateway()
        {
            IPAddress result = null;
            var cards = NetworkInterface.GetAllNetworkInterfaces().ToList();
            if (cards.Any())
            {
                foreach (var card in cards)
                {
                    var props = card.GetIPProperties();
                    if (props == null)
                        continue;

                    var gateways = props.GatewayAddresses;
                    if (!gateways.Any())
                        continue;

                    var gateway =
                        gateways.FirstOrDefault(g => g.Address.AddressFamily.ToString() == "InterNetwork");
                    if (gateway == null)
                        continue;

                    result = gateway.Address;
                    break;
                };
            }

            return result;
        }
        #endregion

        #region DNS Server
        // Auslesen des DNS-Servers

        private static IPAddress GetDnsAdress()
        {
            NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface networkInterface in networkInterfaces)
            {
                if (networkInterface.OperationalStatus == OperationalStatus.Up)
                {
                    IPInterfaceProperties ipProperties = networkInterface.GetIPProperties();
                    IPAddressCollection dnsAddresses = ipProperties.DnsAddresses;

                    foreach (IPAddress dnsAdress in dnsAddresses)
                    {
                        return dnsAdress;
                    }
                }
            }

            throw new InvalidOperationException("Unable to find DNS Address");
        }
        #endregion

        #region Kopier-Buttons
        // Buttons "Kopieren" -> Textboxwert wird in den Zwischenspeicher kopiert

        private void pxb_IPAdresse_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetDataObject(txb_IPAdresse.Text, true);
        }

        private void pxb_Gateway_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetDataObject(txb_Gateway.Text, true);
        }

        private void pbx_DNSServer_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetDataObject(txb_DNSServer.Text, true);
        }

        private void pbx_MACAdresse_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetDataObject(txb_MACAdresse.Text, true);
        }

        private void pbx_CopyAll_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetDataObject(txb_IPAdresse.Text + "\r\n" + txb_Gateway.Text + "\r\n" + txb_DNSServer.Text + "\r\n" + txb_MACAdresse.Text, true);
        }
        #endregion

        #region Sprachauswahl
        // Umstellen der Sprache nach Auswahl

        private void ddl_Language_Changed(object sender, EventArgs e)
        {

            if (ddl_Language.Text == "English")
            {
                lbl_IPAdresse.Text = "IP address:";
                lbl_Gateway.Text = "Gateway:";
                lbl_DNSServer.Text = "DNS server:";
                lbl_MACAdresse.Text = "MAC address:";
                btn_InfosAuslesen.Text = "refresh...";
            }
            else
            {
                lbl_IPAdresse.Text = "IP-Adresse:";
                lbl_Gateway.Text = "Gateway:";
                lbl_DNSServer.Text = "DNS-Server:";
                lbl_MACAdresse.Text = "MAC-Adresse:";
                btn_InfosAuslesen.Text = "erneuern...";
            }
        }
        #endregion

        #region Info-Button
        // Ruft ein zweites Form mit Programminformationen auf

        private void pbx_Info_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            form.Focus();
            this.Visible = false;
        }
        #endregion
    }
}
