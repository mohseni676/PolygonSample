
using Nethereum.RPC.Eth.DTOs;
using Org.BouncyCastle.Math;

namespace PolygonSample
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }





        private async void button1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            var result = await PolygonService.getContractBalance(address: addressTxt.Text, contractAddress: tokenContractTxt.Text);
            balanceLbl.Text = result.BalanceOfToken.ToString();
            decimalsLbl.Text = result.decimalsOfToken.ToString();
            tokenNameLbl.Text = result.name;
            this.Cursor = Cursors.Default;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                var txRes = await PolygonService.transferTokens(prvKeyTxt.Text, trxTokenAddress.Text, amountTxt.Text, toTxt.Text);
                
                resultLstBox.Items.Clear();
                resultLstBox.Items.Add("TxHash : "+txRes.TransactionHash.ToString());
                resultLstBox.Items.Add("Block : " + txRes.BlockNumber);
                this.Cursor = Cursors.Default;
                MessageBox.Show("Transaction successful","Success");

            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;

                MessageBox.Show(ex.Message,"Error");
            }

        }

        private void addressTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
