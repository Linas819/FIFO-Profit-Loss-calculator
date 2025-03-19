using System.Diagnostics;
using System.Reflection;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace FIFO_Profit_Loss_Calculator
{
    public partial class Form1 : Form
    {
        List<Trade> trades;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "CSV files (*.csv)|*.csv";
                dialog.Title = "Select file";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    List<string> linesList = File.ReadAllLines(dialog.FileName).ToList();
                    //Uses the first element in the list and splits the Headers into an array
                    string[] dataHeaderNames = linesList[0].Split(';');
                    trades = new List<Trade>(); // Resets Trades list data
                    foreach (string line in linesList.Skip(1))
                    {
                        Trade trade = new Trade();
                        Type tradeType = trade.GetType();
                        string[] data = line.Split(";");
                        int i = 0;
                        //Based on the current headername in the cycle, gets the property of the trade object and adds the value to the property in regards to the i variable's place
                        foreach (string headerName in dataHeaderNames)
                        {
                            PropertyInfo tradePropertyInfo = tradeType.GetProperty(headerName);
                            switch (headerName) //As not all object's variable are the same type, some neet to be converted, before being assigned
                            {
                                case "TradeId":
                                case "Amount":
                                    tradePropertyInfo.SetValue(trade, Int32.Parse(data[i]));
                                    break;
                                case "Type":
                                case "Client":
                                case "Security":
                                    tradePropertyInfo.SetValue(trade, data[i]);
                                    break;
                                case "Price":
                                case "Fee":
                                    tradePropertyInfo.SetValue(trade, Convert.ToDecimal(data[i].Replace(",", ".")));
                                    break;
                                case "Date":
                                    tradePropertyInfo.SetValue(trade, Convert.ToDateTime(data[i]));
                                    break;
                                default: break;
                            }
                            i++;
                        }
                        trades.Add(trade); //Once all of the information is assigned, the trade object is added to the list
                    }
                    trades = trades.OrderBy(x => x.Date).ToList(); // Orders information by date for easier tracking
                    tradeBindingSource.DataSource = trades; // Binds the data from CSV in Trades List to the Data source Grid View
                    List<string> clients = trades.Select(x => x.Client).Distinct().ToList();
                    foreach (string client in clients)
                    {
                        clientsList.Items.Add(client);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Calculates the transaction using the FIFO forumla
        public decimal GetTransactionValue(int amount, decimal price, decimal fee)
        {
            decimal transactionValue =
                (amount * price) +
                Math.Abs(
                    (amount * price)
                    * fee);
            return transactionValue;
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            List<SecurityProfit> securityProfits = new List<SecurityProfit>();
            DateTime dateTime; // Converts date time string to DateTime variable
            try
            {
                dateTime = Convert.ToDateTime(dateTimePicker1.Text);
                //Check if the client and their transaction exist before the date
                List<Trade> clientTrades = trades.Where(x => x.Client == clientsList.Text && x.Date <= dateTime).ToList();
                List<string> securities = clientTrades.Select(x => x.Security).Distinct().ToList();

                foreach (string security in securities)
                {
                    List<Trade> buyTrades = new List<Trade>();
                    SecurityProfit securityProfit = new SecurityProfit();
                    securityProfit.Security = security;
                    List<Trade> securityTrades = clientTrades.Where(x => x.Security == security).ToList();
                    foreach (Trade securityTrade in securityTrades)
                    {
                        if (securityTrade.Type == "BUY")
                            buyTrades.Add(securityTrade);
                        else //SELL
                        {
                            foreach (Trade buyTrade in buyTrades)
                            {
                                if (buyTrade.Amount >= securityTrade.Amount) // Checks to see if the sale is for less securities than was purchased
                                {
                                    decimal buyTransaction = GetTransactionValue(securityTrade.Amount, buyTrade.Price, buyTrade.Fee);
                                    decimal sellTransaction = GetTransactionValue(securityTrade.Amount, securityTrade.Price, securityTrade.Fee);
                                    securityProfit.Profit = securityProfit.Profit + (sellTransaction - buyTransaction);
                                    buyTrade.Amount = buyTrade.Amount - securityTrade.Amount; // reduces the purchased amount from the buy sale
                                    break;
                                }
                                else
                                {
                                    decimal buyTransaction = GetTransactionValue(buyTrade.Amount, buyTrade.Price, buyTrade.Fee);
                                    decimal sellTransaction = GetTransactionValue(buyTrade.Amount, securityTrade.Price, securityTrade.Fee);
                                    securityProfit.Profit = securityProfit.Profit + (sellTransaction - buyTransaction);
                                    securityTrade.Amount = securityTrade.Amount - buyTrade.Amount; // reduces The sold amount when calculating the other buy trades
                                }
                            }
                        }
                    }
                    securityProfits.Add(securityProfit);
                }
                string text = "";
                foreach (SecurityProfit securityProfit in securityProfits)
                {
                    text = text + securityProfit.Security + "\t" + securityProfit.Profit + "\n";
                }
                richTextBox1.Text = text;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
